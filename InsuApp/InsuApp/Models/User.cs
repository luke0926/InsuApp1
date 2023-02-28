using InsuApp1.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public UserCategory? UserCategory { get; set; }
    }
}
