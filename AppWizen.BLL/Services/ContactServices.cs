using AppWizenz.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AppWizen.BLL.Services
{
    
    public class ContactServices
    {
        private SqlCommand command = null;
        private SqlDataAdapter adapter = null;

        /// <summary>
        /// METODO QUE TRAE EL ID DE LOS CONTACTOS
        /// </summary>
        /// <returns></returns>
        public List<DTOs.ContactDTO> GetContacServices()
        {
            try
            {
                var listGetContacAppSuser = new List<DTOs.ContactDTO>();

                command = new SqlCommand("Adm.spContactSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    listGetContacAppSuser.Add(new DTOs.ContactDTO
                    {
                        ContactId = (int)item["ContactId"] ,
                        FirstName = (string)item["FirstName"]

                    });
                }
                return listGetContacAppSuser;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
