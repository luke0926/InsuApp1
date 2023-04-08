using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace InsuApp1.Models
{
    public class ChartValue
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int ChartValueId { get; set; }
        /// <summary>
        /// Name of user insurance
        /// </summary>
        public string? UserInsuranceName { get; set; }
        /// <summary>
        /// Total value of each insurance type
        /// </summary>
        public int? ChartValueTotal { get; set; }
    }
}
