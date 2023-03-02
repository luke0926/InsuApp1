using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsurance
    {
        public int MainInsuranceId { get; set; }
        [Display(Name = "Název pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuranceName { get; set; }
        //public User? UserMainInsurance { get; set; }
    }
}
