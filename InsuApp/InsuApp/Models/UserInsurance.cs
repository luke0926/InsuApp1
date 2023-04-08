using DocuSign.eSign.Model;
using InsuApp1.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class UserInsurance
    {
        /// <summary>
        /// Id
        /// </summary>
        public int UserInsuranceId { get; set; }
        /// <summary>
        /// User Insurance Name
        /// </summary>
        [Display(Name = "Název pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? InsuranceName { get; set; }
        /// <summary>
        /// User Insurance Value
        /// </summary>
        [Display(Name = "Výše pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuranceValue { get; set; }
        /// <summary>
        /// User Insurance Object
        /// </summary>
        [Display(Name = "Předmět pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsurance { get; set; }
        /// <summary>
        /// User Insurance Valid from date
        /// </summary>
        public DateTime? InsuranceValidFrom { get; set; }
        /// <summary>
        /// User Insurance Valid to date
        /// </summary>
        public DateTime? InsuranceValidTo { get; set; }
        /// <summary>
        /// User model data access
        /// </summary>
        public User? UserUserInsurance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? UserUserInsuranceName { get; set; }
        /// <summary>
        /// Insurance Currency Enum data
        /// </summary>
        [Required(ErrorMessage = "Povinný údaj")]
        public InsuranceCurrency? InsuranceCurrency { get; set; }
        /// <summary>
        /// Main insurance model data access
        /// </summary>
        public MainInsurance? MainInsurance { get; set; }
    }
}
