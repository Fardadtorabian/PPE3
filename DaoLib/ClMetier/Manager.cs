using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace LibDao
{
    public class Manager : IDisposable
    {
        protected ConnexionSqlServer connexionSqlServer = null;
        protected SqlConnection sqlConnexion = null;

        //*****************************************************************************************************************
        public Manager()
        {
            connexionSqlServer = new ConnexionSqlServer();
            sqlConnexion = connexionSqlServer.Connexion;
        }

        public Manager(ConnexionSqlServer connexionSqlServer)
        {
            this.connexionSqlServer = connexionSqlServer;
            sqlConnexion = connexionSqlServer.Connexion;
        }

        public ConnexionSqlServer getConnexion()
        {
            return connexionSqlServer;
        }
        //*****************************************************************************************************************
        public void getListe<T>(ref List<T> maList, String nomTable)
        {
            // Initialisation de la commande associée à la connexion en cours
            // pour une commande "select * " on utilise pas de procédure stockée
            String sql = "select * from " + nomTable;
            SqlCommand sqlCmd = new SqlCommand(sql, sqlConnexion);
            try
            {
                // Ouverture de la connexion
                if (sqlConnexion.State != ConnectionState.Open)
                {
                    sqlConnexion.Open();
                }
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                if (dataReader != null && dataReader.HasRows)
                {
                    maList = DataReader2List<T>(dataReader);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                maList = null;
            }
        }


        //*****************************************************************************************************************
        // Méthode qui retourne une liste d'objets dont les attributs sont contenus dans le dataReader 
        // et  dont le type est passé en paramètre (type des entités) exemple Materiel, Client etc
        //*****************************************************************************************************************
        protected List<T> DataReader2List<T>(IDataReader dataReader)
        {
            List<T> list = new List<T>(); // On instancie une list d'objet de type T
            T entite = default(T); // On defini une référence d'objet de type T 
            //On récupère le nombre de colonne du dataReader
            int nbrColonnes = dataReader.FieldCount;

            while (dataReader.Read())
            {
                //Activator contient des méthodes permettant de créer des types d'objets
                //CreateInstance<T> crée un objet du type <T> dont le nom est spécifié par T et avec le constructeur par defaut
                entite = Activator.CreateInstance<T>();

                ////On récupère chaque élément d'un enregistrement
                //for (int i = 0; i < nbrColonnes; i++)
                //{
                //    // Il faut récupérer chaque nom de colonne pour l'affecter à la propriéte de l'objet matériel
                //    string nomColonne = dataReader.GetName(i);
                //    // Il aurait fallu que chaque nom de colonne en BDD commence par une majuscule
                //    // On est obliger de mettre en majuscule la première lettre de la valeur récupérée
                //    // pour qu'elle soit égale au nom de la propriété correspondante de l'objet
                //    // Exemple idMateriel --> IdMateriel
                //    nomColonne = nomColonne[0].ToString().ToUpper() + nomColonne.Substring(1);
                //    // On récupère de quel type est la valeur en BDD (exemple SqlDbType.NVarChar) 
                //    PropertyInfo propertyInfo = entite.GetType().GetProperty(nomColonne);
                //    //On affecte la valeur lue en BDD à la propriété de l'entité
                //    propertyInfo.SetValue(entite, (dataReader[i] == DBNull.Value) ? null : dataReader[i], null);
                //}

                // Autre possibilité : Partir de l'entité et rechercher sa valeur dans le dataReader
                //GetProperties() permet de récupérer tous les objets propriétés de lobjet entite
                foreach (PropertyInfo propertyInfo in entite.GetType().GetProperties())
                {
                    if (!object.Equals(dataReader[propertyInfo.Name], DBNull.Value))
                    {
                        propertyInfo.SetValue(entite, dataReader[propertyInfo.Name], null);
                    }
                }

                list.Add(entite);
            }
            return list;
        }

        //*****************************************************************************************************************
        // Méthode qui retourne un objet (entité) dont les attributs sont contenus dans le dataReader 
        // et dont le type est passé en paramètre (type des entités) exemple Materiel, Client etc
        //*****************************************************************************************************************
        protected T DataReader2Obj<T>(IDataReader dataReader)
        {
            T entite = default(T); // On defini une référence d'objet de type T 
            //On récupère le nombre de colonne du dataReader
            int nbrColonnes = dataReader.FieldCount;

            //Activator contient des méthodes permettant de créer des types d'objets
            //CreateInstance<T> crée un objet du type <T> dont le nom est spécifié par T et avec le constructeur par defaut
            entite = Activator.CreateInstance<T>();

            //On récupère chaque élément d'un enregistrement
            for (int i = 0; i < nbrColonnes; i++)
            {
                // Il faut récupérer chaque nom de colonne pour l'affecter à la propriéte de l'objet matériel
                string nomColonne = dataReader.GetName(i);
                // Il aurait fallu que chaque nom de colonne en BDD commence par une majuscule
                // On est obliger de mettre en majuscule la première lettre de la valeur récupérée
                // pour qu'elle soit égale au nom de la propriété correspondante de l'objet
                // Exemple idMateriel --> IdMateriel
                nomColonne = nomColonne[0].ToString().ToUpper() + nomColonne.Substring(1);
                // On récupère de quel type est la valeur en BDD (exemple SqlDbType.NVarChar) 
                PropertyInfo propertyInfo = entite.GetType().GetProperty(nomColonne);
                //On affecte la valeur lue en BDD à la propriété de l'entité
                propertyInfo.SetValue(entite, (dataReader[i] == DBNull.Value) ? null : dataReader[i], null);
            }
            return entite;
        }
        //*****************************************************************************************************************

        //*****************************************************************************************************************
        public void Dispose()
        {
            if (connexionSqlServer != null)
                connexionSqlServer.closeConnexion();
        }
        //*****************************************************************************************************************
    }
}
