using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWizenz.DAL.Data
{
    public class ConnectionDB
    {
        private static SqlConnection connection = null;

        public  ConnectionDB()
        {

        }
        /// <summary>
        /// METODO QUE ESTABLECE LA CONEXIÓN
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection() 
        {

            try
            {
                if (connection == null)
                {
                    string cnx = ConfigurationManager.ConnectionStrings["CnxAppUser"].ToString();
                    connection = new SqlConnection(cnx);
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// METODO QUE CIERRA LA CONEXIÓN
        /// </summary>
        public static void CloseConnection() 
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }


       
    }
}
