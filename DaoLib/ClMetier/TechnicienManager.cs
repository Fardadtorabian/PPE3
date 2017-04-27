using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace LibDao
{
    public class TechnicienManager : Manager
    {
        // Constructeur par défaut
        public TechnicienManager()
        {
        }

        // Constructeur avec passage de paramètres pour initialiser les attributs de la classe mère
        public TechnicienManager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }

        //*****************************************************************************************************************
        public Technicien getTechnicien(Technicien technicien)
        {
            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetTechnicien";

            // paramètres passées à la procédure stockée

            sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = technicien.LoginT;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = technicien.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = technicien.Nom;
            sqlCmd.Parameters.Add("@pIdMateriel", SqlDbType.Int).Value = technicien.FkIdMateriel;
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
                    technicien = DataReader2Obj<Technicien>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Erreur recherche technicien \n");
            }
            return technicien;
        }

        //*****************************************************************************************************************
        public bool ajoutModifTechnicien(ref Technicien technicien)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdateTechnicien";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = technicien.LoginT;
            sqlCmd.Parameters.Add("@pPrenom", SqlDbType.NVarChar, 20).Value = technicien.Prenom;
            sqlCmd.Parameters.Add("@pNom", SqlDbType.NVarChar, 30).Value = technicien.Nom;
            sqlCmd.Parameters.Add("@pPasswdT", SqlDbType.NVarChar, 32).Value = technicien.PasswdT;
            if (technicien.FkIdMateriel > 0)
            {              
                sqlCmd.Parameters.Add("@pFkIdMateriel", SqlDbType.Int).Value = technicien.FkIdMateriel;
            }
            else
            {
                sqlCmd.Parameters.Add("@pFkIdMateriel", SqlDbType.Int).Value = DBNull.Value;
            }

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
                throw new Exception("Erreur lors de l'ajout ou modification d'un technicien");
            }
            return retour;
        }
        //*****************************************************************************************************************
        // On passe en paramètre un utilisateur qui se voit supprimer
        // on retourne True si tout s'est bien passé
        public bool supprimerTechnicien(Technicien prmTechnicien)
        {
            Technicien technicien = getTechnicien(prmTechnicien); // On récupère un objet complet
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;

            if (technicien.LoginT != "") // il y a un Technicien à supprimer
            {
                sqlCmd.CommandText = @"spTechnicienDelete";
                // paramètres passées à la procédure stockée
                sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = technicien.LoginT;
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
                    throw new Exception("Erreur lors de la suppression d'un Technicien \n" + ex.Message);
                }
            }
            return retour;
        }

        //*****************************************************************************************************************     
        public bool insUpdatePosTechnicien(ref PositionTechnicien positionTechnicien)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdatePosTechnicien";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pLatitude", SqlDbType.NVarChar, 15).Value = positionTechnicien.Latitude;
            sqlCmd.Parameters.Add("@pLongitude", SqlDbType.NVarChar, 15).Value = positionTechnicien.Longitude;
            sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = positionTechnicien.FkLoginT;
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
                throw new Exception("Erreur lors de la modification d'une position technicien");
            }
            return retour;
        }
              
        //*****************************************************************************************************************
        public bool insUpdateSessionTechnicien(ref SessionTechnicien sessionTechnicien)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et nom de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdateSessionTechnicien";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pJeton", SqlDbType.NVarChar, 255).Value = sessionTechnicien.Jeton;
            sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = sessionTechnicien.FkLoginT;
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
                throw new Exception("Erreur lors de la modification session technicien");
            }
            return retour;
        }

        //*****************************************************************************************************************   
    }
}
