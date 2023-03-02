using InsuApp1.Data.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class UserDetailViewModelEvent
    {
        //User Insured Event Data
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? MainInsuredEventName { get; set; }
        [Display(Name = "Výše škody")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuredEventValue { get; set; }
        [Display(Name = "Předmět události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsuredEvent { get; set; }
        public DateTime? InsuredEventDate { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? MainInsuEventList { get; set; }
        public List<UserInsuredEvent>? UserInsuredEvents { get; set; }
        //User Data
        public User? UserDetailEventView { get; set; }
        [Key]
        public int UserDetailEventId { get; set; }
        public UserCategory? UserCategory { get; set; }
    }
}
