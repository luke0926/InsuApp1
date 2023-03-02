using InsuApp1.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Display(Name = "Uživatelské jméno")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? UserName { get; set; }
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? FirstName { get; set; }
        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Povinný údaj")]
        public UserCategory? UserCategory { get; set; }
    }
}
