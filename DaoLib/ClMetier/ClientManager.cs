using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using LibDao.Entites;

namespace LibDao
{
    public class ClientManager : Manager
    {
        // Constructeur par défaut
        public ClientManager() {}
       
        // Constructeur avec passage de paramètres pour initialiser les attributs de la classe mère
        public ClientManager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }
       
        //*****************************************************************************************************************
        public Client getClient(Client prmClient)
        {
            Client client = null;
            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetClient";

            // paramètres passées à la procédure stockée
            sqlCmd.Parameters.Add("@pIdClient", SqlDbType.Int).Value = prmClient.IdClient;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = prmClient.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = prmClient.Nom;
            try
            {
                // On se connecte
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                // Lecture de l' enregistrements contenus dans le DataRead
                if (dataReader.Read() == true) // un Materiel trouvé
                {
                    client = DataReader2Obj<Client>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Erreur recherche Client \n");
            }
            return client;
        }

        //*****************************************************************************************************************      
        public bool insUpdateClient(Client prmClient)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdateClient";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pIdClient", SqlDbType.Int).Value = prmClient.IdClient;
            sqlCmd.Parameters.Add("@pEntreprise", SqlDbType.NVarChar, 75).Value = prmClient.Entreprise;
            sqlCmd.Parameters.Add("@pFkIdCivilite", SqlDbType.Int).Value = prmClient.FkIdCivilite;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = prmClient.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = prmClient.Nom;
            sqlCmd.Parameters.Add("@pAdresse", SqlDbType.NVarChar, 75).Value = prmClient.Adresse;
            sqlCmd.Parameters.Add("@pCompAdresse", SqlDbType.NVarChar, 75).Value = prmClient.CompAdresse;
            sqlCmd.Parameters.Add("@pCodePostal", SqlDbType.VarChar, 10).Value = prmClient.CodePostal;
            sqlCmd.Parameters.Add("@pVille", SqlDbType.NVarChar, 30).Value = prmClient.Ville;
            sqlCmd.Parameters.Add("@pNumeroTel", SqlDbType.VarChar, 12).Value = prmClient.NumeroTel;
            sqlCmd.Parameters.Add("@pEmail", SqlDbType.VarChar, 30).Value = prmClient.Email;
            sqlCmd.Parameters.Add("@pPhotoent", SqlDbType.VarBinary).Value = prmClient.Photoent;
            sqlCmd.Parameters.Add("@pLatitude", SqlDbType.NVarChar, 20).Value = prmClient.Latitude;
            sqlCmd.Parameters.Add("@pLongitude", SqlDbType.NVarChar, 20).Value = prmClient.Longitude;
            sqlCmd.Parameters.Add("@pFkIdEtatClient", SqlDbType.Int).Value = prmClient.FkIdEtatClient;
            sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = prmClient.FkLoginE;

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
                throw new Exception("Erreur lors de l'ajout ou modification client");
            }
            return retour;
        }
        //*****************************************************************************************************************
        // On passe en paramètre un utilisateur qui se voit supprimer
        // on retourne True si tout s'est bien passé
        public bool supprimerClient(Client prmClient)
        {
            Client client = new Client();
            client=getClient(prmClient);
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            if (client.IdClient != 0)
            {
                sqlCmd.CommandText = @"spClientDelete";
                // paramètres passées à la procédure stockée
                sqlCmd.Parameters.Add("@pIdClient", SqlDbType.Int).Value = client.IdClient;
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
                    throw new Exception("Erreur lors de la suppression d'un client " + ex.Message);
                }
            }
            return retour;
        }
        //*****************************************************************************************************************
    }
}
