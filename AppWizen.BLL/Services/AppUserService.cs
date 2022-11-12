using AppWizenz.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AppWizen.BLL.Services
{
    public  class AppUserService
    {
        private SqlCommand command = null;
        private SqlDataAdapter adapter = null;

       /// <summary>
       ///  METODO QUE RETORNA TODOS LOS USUARIOS
       /// </summary>
       /// <returns></returns>
        public List<DTOs.AppUserDTO> GetAppServices()
        {
            try
            {
                var listGetAppSuser = new List<DTOs.AppUserDTO>();

                command = new SqlCommand("Adm.spGetAppUserSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    listGetAppSuser.Add(new DTOs.AppUserDTO
                    {
                        Username = (string)item["username"],
                        Password = (string)item["password"],
                        ChangePasswordDate = (DateTime)item["changePasswordDate"],
                        Active = (bool)item["active"],
                        RoleId = (int)item["roleId"],
                       // ContactId = (int)item["ContactId"]

                    });
                }
                return listGetAppSuser;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// METODO ENCARGADO DE CREAR USUARIOS
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="changePasswordDate"></param>
        /// <param name="active"></param>
        /// <param name="rolId"></param>
        /// <param name="contactId"></param>
        public void CreateAppUsers(string userName, string password,
                                    DateTime changePasswordDate, 
                                    bool active, int rolId, int contactId, string resultMessage)
        {

            try
            {
                command = new SqlCommand("Adm.spCreateAppUserSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Parametros
                command.Parameters.AddRange(new SqlParameter[] {
                    new SqlParameter("@username ",userName),
                    new SqlParameter("@password ",password),
                    new SqlParameter("@changePasswordDate ",changePasswordDate),
                    new SqlParameter("@active ",active),                   
                    new SqlParameter("@roleId ",rolId),
                    new SqlParameter("@ContactId ",contactId),
                    new SqlParameter("@resultMessage ",resultMessage)
                });

                //Ejecute

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }        
        
        }

        /// <summary>
        /// METODO PARA ACTUALIZAR USUARIO
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="changePasswordDate"></param>
        /// <param name="active"></param>
        /// <param name="rolId"></param>
        /// <param name="contactId"></param>
        public void UpdateAppUsers(int userId,
                                    DateTime changePasswordDate,
                                    bool active, int rolId, int contactId)
        {

            try
            {
                command = new SqlCommand("Adm.spUpdateAppUserSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Parametros
                command.Parameters.AddRange(new SqlParameter[] {
                     new SqlParameter("@userId ",userId),
                    new SqlParameter("@changePasswordDate ",changePasswordDate.Year),
                    new SqlParameter("@active ",active),
                    new SqlParameter("@roleId ",rolId),
                    new SqlParameter("@ContactId ",contactId)                   

                });

                //Ejecute

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void DeleteAppUsers(int userId)

        {

            try
            {
                command = new SqlCommand("Adm.spDeleteAppUserSteven", ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Parametros
                command.Parameters.AddRange(new SqlParameter[] {
                     new SqlParameter("@userId ",userId)
             

                });

                //Ejecute

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
