using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWizenz.DAL.Models
{
    public class Contact
    {
        public Contact()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int ContactId { get; set; }
        public string Identification { get; set; } 
        public int IdentificationTypeId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; }
        public string MobileNumber { get; set; }
        public bool? Active { get; set; }
        public int ContactTypeId { get; set; }
        public int? CustomerId { get; set; }
        public string ExternalCode { get; set; }
        public int DealerId { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
