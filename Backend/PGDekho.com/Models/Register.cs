using System.ComponentModel.DataAnnotations;

namespace PGDekho.com.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string PropertyOwner { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
