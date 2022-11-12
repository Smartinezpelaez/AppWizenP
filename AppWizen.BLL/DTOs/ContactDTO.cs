namespace AppWizen.BLL.DTOs
{
    public   class ContactDTO
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; }
        public string MobileNumber { get; set; }
        public bool? Active { get; set; }
    }
}
