﻿using System.ComponentModel.DataAnnotations;
using InsuApp1.Data.Enum;

namespace InsuApp1.Models
{
    public class UserInsuredEvent
    {
        public int UserInsuredEventId { get; set; }
        [Display(Name = "Název pojistné události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? InsuredEventName { get; set; }
        [Display(Name = "Výše škody")]
        [Required(ErrorMessage = "Povinný údaj")]
        public int? InsuredEventValue { get; set; }
        [Display(Name = "Předmět události")]
        [Required(ErrorMessage = "Povinný údaj")]
        public string? ObjectOfInsuredEvent { get; set; }
        public DateTime? InsuredEventDate { get; set; }
        public User? UserUserInsuredEvent { get; set; }
        [Required(ErrorMessage = "Povinný údaj")]
        public InsuranceCurrency? InsuranceCurrency { get; set; }
        public MainInsuredEvent? MainInsuredEvent { get; set; }
    }
}
