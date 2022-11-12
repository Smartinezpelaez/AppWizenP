using AppWizenz.DAL.Models;
using AutoMapper;

namespace AppWizen.BLL.DTOs
{
    public class MapperConfig 
    {
        public static MapperConfiguration MapperConfiguration()
        {

            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AppUser, AppUserDTO>(); // GET
                cfg.CreateMap<AppUserDTO, AppUser>(); // POST - PUT

                cfg.CreateMap<Contact, ContactDTO>();
                cfg.CreateMap<ContactDTO, Contact>();

                cfg.CreateMap<AppUserRole, AppUserRoleDTO>();
                cfg.CreateMap<AppUserRoleDTO, AppUserRole>();



            });

        }
    }
}
