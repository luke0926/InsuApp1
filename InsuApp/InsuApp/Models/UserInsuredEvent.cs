using System.ComponentModel.DataAnnotations;
using InsuApp1.Data.Enum;

namespace InsuApp1.Models
{
    public class UserInsuredEvent
    {
        /// <summary>
        /// Id
        /// </summary>
        public int UserInsuredEventId { get; set; }
        /// <summary>
        /// User Insured Event name
        /// </summary>
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? InsuredEventName { get; set; }
        /// <summary>
        /// USer Insured Event Value
        /// </summary>
        [Display(Name = "Výše škody")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuredEventValue { get; set; }
        /// <summary>
        /// User Insured Event Object
        /// </summary>
        [Display(Name = "Předmět události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsuredEvent { get; set; }
        /// <summary>
        /// User Insured Event Date
        /// </summary>
        public DateTime? InsuredEventDate { get; set; }
        /// <summary>
        /// User model data access
        /// </summary>
        public User? UserUserInsuredEvent { get; set; }
        /// <summary>
        /// Insured Event Currency Enum Data
        /// </summary>
        [Required(ErrorMessage = "Povinný údaj")]
        public InsuranceCurrency? InsuranceCurrency { get; set; }
        /// <summary>
        /// Main Insured model Event data access
        /// </summary>
        public MainInsuredEvent? MainInsuredEvent { get; set; }
    }
}
