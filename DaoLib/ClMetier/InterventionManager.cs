using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace LibDao
{
    public class InterventionManager : Manager
    {

        // Constructeur par défaut
        public InterventionManager()
        {
        }
        // Constructeur avec passage de paramètres pour initialiser les attributs de la classe mère
        public InterventionManager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }
      
        //*****************************************************************************************************************
        public Intervention getIntervention(Intervention prmIntervention)
        {
            Intervention intervention = null;
            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et CompteRendu de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetInterventionByTechnicienByDate";
            // paramètres passées à la procédure stockée
            sqlCmd.Parameters.Add("@pIdIntervention", SqlDbType.Int).Value = prmIntervention.IdIntervention;
            sqlCmd.Parameters.Add("@pFkLoginT", SqlDbType.NVarChar, 25).Value = prmIntervention.FkLoginT;
            sqlCmd.Parameters.Add("@pDebutIntervention", SqlDbType.DateTime).Value = prmIntervention.DebutIntervention;
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
                    intervention = DataReader2Obj<Intervention>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Erreur recherche Intervention");
            }
            return intervention;
        }

        //*****************************************************************************************************************
        public bool ajouterIntervention(Intervention intervention)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et CompteRendu de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsertIntervention";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pCompteRendu", SqlDbType.Text).Value = intervention.CompteRendu;
            sqlCmd.Parameters.Add("@pDebutIntervention", SqlDbType.DateTime).Value = intervention.DebutIntervention;
            sqlCmd.Parameters.Add("@pFinIntervention", SqlDbType.DateTime).Value = intervention.FinIntervention;
            sqlCmd.Parameters.Add("@pObjectifVisite", SqlDbType.Text).Value = intervention.ObjectifVisite;
            sqlCmd.Parameters.Add("@pPhotoLieu", SqlDbType.VarBinary).Value = intervention.PhotoLieu;
            sqlCmd.Parameters.Add("@pNomContact", SqlDbType.NVarChar, 30).Value = intervention.NomContact;
            sqlCmd.Parameters.Add("@pPrenomContact", SqlDbType.NVarChar, 20).Value = intervention.PrenomContact;
            sqlCmd.Parameters.Add("@pTelContact", SqlDbType.NVarChar, 12).Value = intervention.TelContact;
            sqlCmd.Parameters.Add("@pEtatVisite", SqlDbType.NVarChar, 25).Value = intervention.EtatVisite;
            sqlCmd.Parameters.Add("@pFkLoginE", SqlDbType.NVarChar, 25).Value = intervention.FkLoginE;
            sqlCmd.Parameters.Add("@pFkIdClient", SqlDbType.Int).Value = intervention.FkIdClient;
            sqlCmd.Parameters.Add("@pFkLoginT", SqlDbType.NVarChar, 25).Value = intervention.FkLoginT;

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
                throw new Exception("Erreur lors de l'ajout d'une Intervention ");
            }
            return retour;
        }

        //*****************************************************************************************************************
        // On passe en paramètre une intervention que l'on veut supprimer
        // on retourne True si tout s'est bien passé
        public bool supprimerIntervention(Intervention intervention)
        {
            bool retour = false;

            //Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;
            //Type de commande de commande et CompteRendu de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.CommandText = @"spDeleteInterventionByTechnicienByDate";
            //paramètres passées à la procédure stockée
            sqlCmd.Parameters.Add("@pFkLoginT", SqlDbType.NVarChar, 25).Value = intervention.FkLoginT;
            sqlCmd.Parameters.Add("@pDebutIntervention", SqlDbType.DateTime).Value = intervention.DebutIntervention;
            try
            {
                //On ouvre la connexion
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                //On appelle la procédure stockée
                if ((int)sqlCmd.ExecuteNonQuery() == -1)
                {
                    retour = true;
                }
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception("Erreur lors de la suppression d'une Intervention");
            }
            return retour;
        }

        //*****************************************************************************************************************
        // L'intervention est connue par son Id
        public bool updateIntervention(Intervention intervention)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et CompteRendu de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spUpdateInterventionById";

            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pIdIntervention", SqlDbType.Int).Value = intervention.IdIntervention;
            sqlCmd.Parameters.Add("@pCompteRendu", SqlDbType.Text).Value = intervention.CompteRendu;
            sqlCmd.Parameters.Add("@pDebutIntervention", SqlDbType.DateTime).Value = intervention.DebutIntervention;
            sqlCmd.Parameters.Add("@pFinIntervention", SqlDbType.DateTime).Value = intervention.FinIntervention;
            sqlCmd.Parameters.Add("@pObjectifVisite", SqlDbType.Text).Value = intervention.ObjectifVisite;
            sqlCmd.Parameters.Add("@pPhotoLieu", SqlDbType.VarBinary).Value = intervention.PhotoLieu;
            sqlCmd.Parameters.Add("@pNomContact", SqlDbType.NVarChar, 30).Value = intervention.NomContact;
            sqlCmd.Parameters.Add("@pPrenomContact", SqlDbType.NVarChar, 20).Value = intervention.PrenomContact;
            sqlCmd.Parameters.Add("@pTelContact", SqlDbType.NVarChar, 12).Value = intervention.TelContact;
            sqlCmd.Parameters.Add("@pEtatVisite", SqlDbType.NVarChar, 25).Value = intervention.EtatVisite;
            sqlCmd.Parameters.Add("@pFkLoginE", SqlDbType.NVarChar, 25).Value = intervention.FkLoginE;
            sqlCmd.Parameters.Add("@pFkIdClient", SqlDbType.Int).Value = intervention.FkIdClient;
            sqlCmd.Parameters.Add("@pFkLoginT", SqlDbType.NVarChar, 25).Value = intervention.FkLoginT;

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
                throw new Exception("Erreur lors de la modification d'une intervention");
            }
            return retour;
        }

        //*****************************************************************************************************************
       
        public List<Intervention> listeInterventionsTechnicien(Intervention prmIntervention)
        {
            // pour une commande "select * " on utilise pas de procédure stockée
            List<Intervention> listInterventions = null;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetlistInterventionsByTechnicienByDate";

            sqlCmd.Parameters.Add("@pFkLoginT", SqlDbType.NVarChar, 25).Value = prmIntervention.FkLoginT;
            sqlCmd.Parameters.Add("@pDateJour", SqlDbType.DateTime).Value = prmIntervention.DebutIntervention;
            try
            {
                // On se connecte
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                // Lecture de tous les enregistrements contenus dans le DataRead              
                //Exécuter si le dataReader existe et  n'est pas vide
                if (dataReader != null && dataReader.HasRows)
                {
                    listInterventions = DataReader2List<Intervention>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception("Erreur lors de la récupération liste des Interventions");
            }
            return listInterventions;
        }

        //*****************************************************************************************************************
    }
}
