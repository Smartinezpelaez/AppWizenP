using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWizenz.DAL.Models
{
   public class AppUserRole
    {
        public AppUserRole()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } 
        public int AlertAttentionLevel { get; set; }
        public bool ExternalManagementAccountsEnabled { get; set; }
        public int? ServiceId { get; set; }
        public int RoleManagementLevel { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
