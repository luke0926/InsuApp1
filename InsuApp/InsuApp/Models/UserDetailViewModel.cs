using InsuApp1.Data.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class UserDetailViewModel
    {
        //User Insurance Data

        /// <summary>
        /// Insurance Name
        /// </summary>
        public string? InsuranceName { get; set; }
        /// <summary>
        /// Insurance Value
        /// </summary>
        [Display(Name = "Výše pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuranceValue { get; set; }
        /// <summary>
        /// Object of Insurance
        /// </summary>
        [Display(Name = "Předmět pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsurane { get; set; }
        /// <summary>
        /// Insurance Valid date from
        /// </summary>
        public DateTime? InsuranceValidFrom { get; set; }
        /// <summary>
        /// Insurance Valid date to
        /// </summary>
        public DateTime? InsuranceValidTo { get; set; }
        /// <summary>
        /// User Insurances List
        /// </summary>
        public List<UserInsurance>? UserInsurances { get; set; }

        //User Data

        /// <summary>
        /// User model data access
        /// </summary>
        public User? UserDetailView { get; set; }
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int UserDetailViewId { get; set; }

        //Main Insurance Data

        //public List<MainInsurance>? MainInsurances { get; set; }
        /// <summary>
        /// Main Insurance name used for User Insurance model
        /// </summary>
        [Display(Name = "Název pojištění")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuranceName { get; set; }
        //public MainInsurance? MainInsurancedw { get; set; }
        /// <summary>
        /// Main Insurances Select List
        /// </summary>
        [NotMapped]
        public virtual IEnumerable<SelectListItem>? MainInsuList { get; set; }

        //User Insured Event Data

        /// <summary>
        /// User Insured model data access
        /// </summary>
        public UserInsuredEvent? UserInsuredEvent { get; set; }
        /// <summary>
        /// Main Isnured Events Select List
        /// </summary>
        [NotMapped]
        public virtual IEnumerable<SelectListItem>? MainInsuEventList { get; set; }
        /// <summary>
        /// User Insured Events List
        /// </summary>
        public List<UserInsuredEvent>? UserInsuredEvents { get; set; }

        //Enum Data

        /// <summary>
        /// User Category Enum data for User Detail view model
        /// </summary>
        public UserCategory? UserCategory { get; set; }
        /// <summary>
        /// Insurance Currency Enum data for User Detail view model
        /// </summary>
        [Required(ErrorMessage = "Povinný údaj")]
        public InsuranceCurrency? InsuranceCurrency { get; set; }
    }
}
