using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace LibDao
{
    public class MaterielManager : Manager
    {
        // Constructeur par défaut
        public MaterielManager()
        {
        }
        // Constructeur avec passage de paramètres pour initialiser les attributs de la classe mère
        public MaterielManager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }

        //*****************************************************************************************************************
        public Materiel getMateriel(ref Materiel prmMateriel)
        {
            Materiel materiel = null;
            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et DateRemise de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spGetMateriel";

            // paramètres passées à la procédure stockée
            sqlCmd.Parameters.Add("@pIdMateriel", SqlDbType.Int).Value = prmMateriel.IdMateriel;
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
                    materiel = DataReader2Obj<Materiel>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Erreur recherche Materiel \n");
            }
            return materiel;
        }

        //*****************************************************************************************************************
        // On passe en paramètre un matériel a supprimer
        // on retourne True si tout s'est bien passé
        public bool supprimerMateriel(Materiel prmMateriel)
        {
            prmMateriel = getMateriel(ref prmMateriel); // On récupère un objet complet
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et DateRemise de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;

            if (prmMateriel.IdMateriel != 0) // il y a une EntityMateriel à supprimer
            {
                sqlCmd.CommandText = @"spMaterielDelete";
                // paramètres passées à la procédure stockée
                sqlCmd.Parameters.Add("@pIdMateriel", SqlDbType.Int).Value = prmMateriel.IdMateriel;

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
                    throw new Exception("Erreur lors de la suppression d'une Materiel \n" + ex.Message);
                }
            }
            return retour;
        }

        //*****************************************************************************************************************
        // Le matériel est connu par son Id
        public bool insertUpdateMateriel(ref Materiel prmMateriel)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et DateRemise de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spInsUpdateMateriel";
            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pTypeMateriel", SqlDbType.NVarChar, 100).Value = prmMateriel.TypeMateriel;
            sqlCmd.Parameters.Add("@pNumeroSerie", SqlDbType.NVarChar, 50).Value = prmMateriel.NumeroSerie;
            sqlCmd.Parameters.Add("@pNumeroTel", SqlDbType.NVarChar, 12).Value = prmMateriel.NumeroTel;
            sqlCmd.Parameters.Add("@pImei", SqlDbType.NVarChar, 17).Value = prmMateriel.Imei;
            sqlCmd.Parameters.Add("@pIdGoogle", SqlDbType.Text).Value = prmMateriel.IdGoogle;
            sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = prmMateriel.FkLoginE;
            sqlCmd.Parameters.Add("@pEtatMateriel", SqlDbType.NVarChar, 15).Value = prmMateriel.EtatMateriel;

            // On persiste les data
            try
            {
                // On se connecte
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                // On appelle la procédure stockée qui retourne le nombre de ligne modifiée
                if ((int)sqlCmd.ExecuteNonQuery() == 1) // une ligne a été modifiée
                {
                    retour = true; // Une ligne a été modifiée dans la BDD tvb
                }
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception("Erreur insertion ou modification d'un Materiel \n" + ex.Message);
            }
            return retour;
        }

        //*****************************************************************************************************************
        // Le matériel est connu par son Id
        public bool affectationMaterielTechnicien(ref Materiel materiel, ref Technicien technicien)
        {
            bool retour = false;

            // Initialisation de la commande associée à la connexion en cours
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnexion;

            // Type de commande de commande et DateRemise de la procédure appelée
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = @"spAffectationMatériel";
            // paramètres passés à la procédure stockée
            sqlCmd.Parameters.Add("@pIdMateriel", SqlDbType.Int).Value = materiel.IdMateriel;
            sqlCmd.Parameters.Add("@pNumeroTel", SqlDbType.NVarChar, 12).Value = materiel.NumeroTel;
            sqlCmd.Parameters.Add("@pImei", SqlDbType.NVarChar, 17).Value = materiel.Imei;
            sqlCmd.Parameters.Add("@pIdGoogle", SqlDbType.Text).Value = materiel.IdGoogle;
            sqlCmd.Parameters.Add("@pLoginT", SqlDbType.NVarChar, 25).Value = technicien.LoginT;
            sqlCmd.Parameters.Add("@pLoginE", SqlDbType.NVarChar, 25).Value = materiel.FkLoginE;
            sqlCmd.Parameters.Add("@pEtatMateriel", SqlDbType.NVarChar, 15).Value = materiel.EtatMateriel;

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
                    retour = true; 
                }
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception("Erreur affectation d'un Materiel \n" + ex.Message);
            }
            return retour;
        }

        //*****************************************************************************************************************
    }
}
