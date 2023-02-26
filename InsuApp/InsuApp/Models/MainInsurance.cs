using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsurance
    {
        public int MainInsuranceId { get; set; }
        [Display(Name = "Name of Insurance")]
        [Required(ErrorMessage = "Name is Required")]
        public string? MainInsuranceName { get; set; }
        //public User? UserMainInsurance { get; set; }
    }
}
