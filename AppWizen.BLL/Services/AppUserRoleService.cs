using AppWizenz.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWizen.BLL.Services
{
   public class AppUserRoleService
    {
        private SqlCommand command = null;
        private SqlDataAdapter adapter = null;

        /// <summary>
        /// METODO QUE TRAE EL ID DE LOS ROLES
        /// </summary>
        /// <returns></returns>
        public List<DTOs.AppUserRoleDTO> GetAppUserRoleServices()
        {
            try
            {
                var listGetAppRoleSuser = new List<DTOs.AppUserRoleDTO>();

                command = new SqlCommand("Conf.spGetAppUserRoleSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    listGetAppRoleSuser.Add(new DTOs.AppUserRoleDTO
                    {
                        RoleId = (int)item["RoleId"],
                        RoleName = (string)item["RoleName"]
                         
                    });
                }
                return listGetAppRoleSuser;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
