using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsurance
    {
        /// <summary>
        /// Id
        /// </summary>
        public int MainInsuranceId { get; set; }
        /// <summary>
        /// Insurance Name
        /// </summary>
        [Display(Name = "Název pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuranceName { get; set; }
        //public User? UserMainInsurance { get; set; }
    }
}
