using System.ComponentModel.DataAnnotations;


namespace InsuApp1.Models
{
    public class UserInsurance
    {
        public int UserInsuranceId { get; set; }
        [Display(Name = "Name of Insurance")]
        [Required(ErrorMessage = "Insurance Type is Required")]
        public string? InsuranceName { get; set; }
        [Display(Name = "Value of Insurance")]
        [Required(ErrorMessage = "Value is Required")]
        public int? InsuranceValue { get; set; }
        [Display(Name = "Object of Insurance")]
        [Required(ErrorMessage = "Object is Required")]
        public string? ObjectOfInsurance { get; set; }
        public DateTime? InsuranceValidFrom { get; set; }
        public DateTime? InsuranceValidTo { get; set; }
        public User? UserUserInsurance { get; set; }
        public string? UserUserInsuranceName { get; set; }
    }
}
