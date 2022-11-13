using System;
using System.ComponentModel.DataAnnotations;

namespace AppWizen.BLL.DTOs
{
    public class AppUserDTO
    {
        [Display(Name = "Id del Usuario")]
        public int UserId { get; set; }

        [Display (Name = "Nombre de Usuario")]
        [Required(ErrorMessage ="The field UserName is required")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field Password is required")]
        public string Password { get; set; }

        [Display(Name = "ChangePasswordDate")]
        [Required(ErrorMessage = "The field ChangePasswordDate is required")]
        public DateTime ChangePasswordDate { get; set; }

        [Display(Name = "Active")]
        [Required(ErrorMessage = "The field Active is required")]
        public bool? Active { get; set; }

        [Display(Name = "Role_Id")]
        [Required(ErrorMessage = "The field RoleId is required")]
        public int RoleId { get; set; }

        [Display(Name = "Contact_Id")]
        [Required(ErrorMessage = "The field ContactId is required")]
        public int ContactId { get; set; }

        [Display(Name = "Mensaje")]
        [Required(ErrorMessage = "The field ContactId is required")]
        public string ResultMessage { get; set; }
    }
}
