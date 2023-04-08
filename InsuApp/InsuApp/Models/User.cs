using InsuApp1.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int UserId { get; set; }
        /// <summary>
        /// User Name (Nickname)
        /// </summary>
        [Display(Name = "Uživatelské jméno")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? UserName { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? FirstName { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? LastName { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? EmailAddress { get; set; }
        /// <summary>
        /// Phone Number
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Street Address
        /// </summary>
        public string? StreetAddress { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// User Category Enum
        /// </summary>
        [Required(ErrorMessage = "Povinný údaj")]
        public UserCategory? UserCategory { get; set; }
    }
}
