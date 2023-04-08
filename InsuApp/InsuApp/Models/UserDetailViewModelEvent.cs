using InsuApp1.Data.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class UserDetailViewModelEvent
    {
        //User Insured Event Data

        /// <summary>
        /// Insured Event Name
        /// </summary>
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuredEventName { get; set; }
        /// <summary>
        /// Isnured Event Value
        /// </summary>
        [Display(Name = "Výše škody")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuredEventValue { get; set; }
        /// <summary>
        /// Insured Event Object
        /// </summary>
        [Display(Name = "Předmět události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsuredEvent { get; set; }
        /// <summary>
        /// Insured Event Date
        /// </summary>
        public DateTime? InsuredEventDate { get; set; }
        /// <summary>
        /// Main Insured Events Select List for User Detail view Event model
        /// </summary>
        [NotMapped]
        public IEnumerable<SelectListItem>? MainInsuEventList { get; set; }
        /// <summary>
        /// User Insured Event List
        /// </summary>
        public List<UserInsuredEvent>? UserInsuredEvents { get; set; }

        //User Data

        /// <summary>
        /// User model data access
        /// </summary>
        public User? UserDetailEventView { get; set; }
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int UserDetailEventId { get; set; }

        //Enum Data

        /// <summary>
        /// User Category Enum data
        /// </summary>
        public UserCategory? UserCategory { get; set; }
        /// <summary>
        /// Insurance Event Currency Enum Data
        /// </summary>
		[Required(ErrorMessage = "Povinný údaj")]
		public InsuranceCurrency? InsuranceCurrency { get; set; }
    }
}
