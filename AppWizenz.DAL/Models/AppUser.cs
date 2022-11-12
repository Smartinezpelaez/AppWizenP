using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWizenz.DAL.Models
{
   public class AppUser
    {
        public int UserId { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; } 
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime? ChangePasswordDate { get; set; }
        public bool? Active { get; set; }
        public int ContactId { get; set; }
        public int RoleId { get; set; }
        public string ResultMessage { get; set; }

        public virtual Contact Contact { get; set; } 
        public virtual AppUserRole Role { get; set; } 

    }
}
