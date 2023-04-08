using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsuredEvent
    {
        /// <summary>
        /// Id
        /// </summary>
        public int MainInsuredEventId { get; set; }
        /// <summary>
        /// Insured Event Name
        /// </summary>
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuredEventName { get; set; }
    }
}
