using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LibDao
{
    public class ConnexionSqlServer
    {
        SqlConnection sqlConnection = null;
        public ConnexionSqlServer()
        {
            try
            {
                string ChaineConnection = ConfigurationManager.ConnectionStrings["SqlConnectionDomy59"].ConnectionString;
                sqlConnection = new SqlConnection(ChaineConnection);
                // Test si connexion possible
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                sqlConnection = null;
                throw new Exception(String.Format("Echec connexion à la base de données  \n"));
            }
        }

        public SqlConnection Connexion
        {
            get { return sqlConnection; }
        }
        public void closeConnexion()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Close();
            }
        }
    }
}