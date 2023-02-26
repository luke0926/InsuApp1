using System.ComponentModel.DataAnnotations;

namespace InsuApp1.Models
{
    public class UserInsuredEvent
    {
        public int UserInsuredEventId { get; set; }
        [Display(Name = "Name of Insured Event")]
        [Required(ErrorMessage = "Event Type is Required")]
        public string? InsuredEventName { get; set; }
        [Display(Name = "Value of Insured Event")]
        [Required(ErrorMessage = "Value is Required")]
        public string? InsuredEventValue { get; set; }
        [Display(Name = "Object of Insured Event")]
        [Required(ErrorMessage = "Object is Required")]
        public string? ObjectOfInsuredEvent { get; set; }
        public DateTime? InsuredEventDate { get; set; }
        public User? UserUserInsuredEvent { get; set; }
    }
}
