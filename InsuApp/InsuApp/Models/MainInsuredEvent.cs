using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsuredEvent
    {
        public int MainInsuredEventId { get; set; }
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuredEventName { get; set; }
    }
}
