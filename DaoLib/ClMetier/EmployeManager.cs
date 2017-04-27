using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace LibDao
{
    public class EmployeManager : Manager
    {
        //*****************************************************************************************************************
        // Constructeur par défaut
        public EmployeManager()
        {

        }
        // Constructeur avec passage de paramètres pour initialiser les attributs de la classe mère
        public EmployeManager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }
      
        //*****************************************************************************************************************
        public Employe getEmploye(ref Employe prmEmploye)
        {
            Employe employe = null;
            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetEmploye";

            // paramètres passées à la procédure stockée
            sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = prmEmploye.LoginE;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = prmEmploye.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = prmEmploye.Nom;
            try
            {
                // On se connecte
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                // Lecture de enregistrements contenus dans le DataRead
                if (dataReader.Read() == true) // un Materiel trouvé
                {
                    employe = DataReader2Obj<Employe>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Erreur recherche Employe");
            }
            return employe;
        }

        //*****************************************************************************************************************
        public bool ajoutModifEmploye(ref Employe employe)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdateEmploye";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = employe.LoginE;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = employe.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = employe.Nom;
            sqlCmd.Parameters.Add("@pGroupe", SqlDbType.NVarChar, 25).Value = employe.Groupe;

            // On persiste les data
            try
            {
                // On se connecte
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                // On appelle la procédure stockée
                if ((int)sqlCmd.ExecuteNonQuery() == -1)
                {
                    retour = true; // Une ligne a été modifiée dans la BDD tvb
                }
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception("Erreur lors de l'ajout d'un employé");
            }
            return retour;
        }

        //*****************************************************************************************************************
        // On passe en paramètre un utilisateur qui se voit supprimer
        // on retourne True si tout s'est bien passé
        public bool supprimerEmploye(Employe employe)
        {
            employe = getEmploye(ref employe); // On récupère un objet complet
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;

            if (employe.LoginE != "") // il y a une EntityEmploye à supprimer
            {
                sqlCmd.CommandText = @"spEmployeDelete";
                // paramètres passées à la procédure stockée
                sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = employe.LoginE;

                try
                {
                    // On ouvre la connexion
                    if (sqlConnexion.State != ConnectionState.Open)
                    {
                        sqlConnexion.Open();
                    }
                    // On appelle la procédure stockée
                    if ((int)sqlCmd.ExecuteNonQuery() == -1)
                    {
                        retour = true;
                    }
                }
                catch (Exception ex)
                {
                    Dispose();
                    throw new Exception("Erreur lors de la suppression d'un employé");
                }
            }
            return retour;
        }
       
        //*****************************************************************************************************************
    }
}
