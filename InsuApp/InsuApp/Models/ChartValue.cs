using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace InsuApp1.Models
{
    public class ChartValue
    {
        [Key]
        public int ChartValueId { get; set; }
        public string? UserInsuranceName { get; set; }
        public int? ChartValueTotal { get; set; }
    }
}
