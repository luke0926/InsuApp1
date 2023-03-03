using DocuSign.eSign.Model;
using InsuApp1.Data.Enum;
using System.ComponentModel.DataAnnotations;


namespace InsuApp1.Models
{
    public class UserInsurance
    {
        public int UserInsuranceId { get; set; }
        [Display(Name = "Název pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? InsuranceName { get; set; }
        [Display(Name = "Výše pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuranceValue { get; set; }
        [Display(Name = "Předmět pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsurance { get; set; }
        public DateTime? InsuranceValidFrom { get; set; }
        public DateTime? InsuranceValidTo { get; set; }
        public User? UserUserInsurance { get; set; }
        public string? UserUserInsuranceName { get; set; }
        [Required(ErrorMessage = "Povinný údaj")]
        public InsuranceCurrency? InsuranceCurrency { get; set; }
    }
}
