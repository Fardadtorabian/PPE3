using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Configuration;
using LibDao;

namespace Dispatcher
{
    public class InfoActiveDirectory
    {
        DirectoryEntry ldapConnexion = null;
        //***************************************************************************************************************
        private bool Connect()
        {
            // récupération des paramètres de connexion dans app.config
            string defaultServer = System.Configuration.ConfigurationManager.AppSettings["LDAP_SERVER"].ToString();
            /** Connecxion à l'AD **/
            try
            {
                //Connexion à l'annuaire Active Directory
                ldapConnexion = new DirectoryEntry(defaultServer);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        //***************************************************************************************************************
        private void Disconnect()
        {
            if (ldapConnexion != null)
            {
                ldapConnexion.Close();
            }
        }
        //***************************************************************************************************************
        public Employe getEmployeFromAD(String login)
        {
            Employe employe = new Employe();
            try
            {
                if (Connect() != false)
                {
                   // on ne cherche que les utilisateurs déclarés sur agence de lille
                    string DomainPath = "LDAP://OU=AgenceLille,DC=domy59,DC=local";
                    DirectoryEntry searchRoot = new DirectoryEntry(DomainPath);
                    // Pour effectuer une recherche dans l'AD, il faut utiliser l'objet DirectorySearcher
                    DirectorySearcher searcher = new DirectorySearcher(searchRoot);
                    //Ensuite, il faut préciser un filtre de recherche, au moyen de la propriété Filter. 
                    // Dans notre cas, nous ne désirons récupérer les utilisateurs via leur login sur la base SAM :
                    searcher.Filter = "samaccountname=" + login;  // recherche par login

                    // on cherche un seul résultat puisque c'est un utilisateur via login (il est unique sur l'AD)
                    // On récupère le premier et seul objet qui corresponde à neotre critère de recherche
                    SearchResult searchResult = searcher.FindOne();

                    if (searchResult != null) // un utilisateur trouvé
                    {
                        // On récupère l'entrée trouvée lors de la recherche
                        DirectoryEntry directoryEntry = searchResult.GetDirectoryEntry();
                        //On peut maintenant peupler l'objet employé avec  les informations désirées
                        employe.LoginE =(string) directoryEntry.Properties["SAMAccountName"].Value;
                        employe.Nom = (string)directoryEntry.Properties["sn"].Value;
                        employe.Prenom = (string)directoryEntry.Properties["givenName"].Value;
                        String nomGroupComplet = (String)directoryEntry.Properties["memberof"].Value;
                        // On récupère par exemple :CN=Administration,OU=AgenceLille,DC=domy59,DC=local
                        // Qu'il faut parser pour récupérer uniquement le nom du groupe
                        char[] splitters = new char[] { ',', '=' };
                        string[] sTab = nomGroupComplet.Split(splitters);
                        employe.Groupe = sTab[1].Trim();
                    }
                }
            }
            catch (Exception e)
            {
                Disconnect();
                return employe;
            }
            Disconnect();
            return employe;
        }
    }
}
