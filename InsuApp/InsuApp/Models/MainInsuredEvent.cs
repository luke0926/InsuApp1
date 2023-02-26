using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class MainInsuredEvent
    {
        public int MainInsuredEventId { get; set; }
        [Display(Name = "Name of Insured Event")]
        [Required(ErrorMessage = "Name is Required")]
        public string? MainInsuredEventName { get; set; }
    }
}
