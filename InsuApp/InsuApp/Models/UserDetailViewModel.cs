using InsuApp1.Data.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuApp1.Models
{
    public class UserDetailViewModel
    {
        //User Insurance Data
        public string? InsuranceName { get; set; }
        [Display(Name = "Value of Insurance")]
        [Required(ErrorMessage = "Value is Required")]
        public string? InsuranceValue { get; set; }
        [Display(Name = "Object of Insurance")]
        [Required(ErrorMessage = "Object is Required")]
        public string? ObjectOfInsurane { get; set; }
        public DateTime? InsuranceValidFrom { get; set; }
        public DateTime? InsuranceValidTo { get; set; }
        public List<UserInsurance>? UserInsurances { get; set; }
        //User Data
        public User? UserDetailView { get; set; }
        [Key]
        public int UserDetailViewId { get; set; }
        //Main Insurance Data
        //public List<MainInsurance>? MainInsurances { get; set; }
        [Display(Name = "Name of Insurance")]
        [Required(ErrorMessage = "Insurance Type id Required")]
        public string? MainInsuranceName { get; set; }
        //public MainInsurance? MainInsurancedw { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? MainInsuList { get; set; }
        //User Insured Event Data
        public UserInsuredEvent? UserInsuredEvent { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? MainInsuEventList { get; set; }
        public List<UserInsuredEvent>? UserInsuredEvents { get; set; }
        public UserCategory? UserCategory { get; set; }
    }
}
