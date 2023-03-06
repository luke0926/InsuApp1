using System.Linq;

namespace InsuApp1.Models
{
	public class InsuranceChart
	{
		public virtual IEnumerable<UserInsurance>? InsuranceValues { get; set; }
		public string? InsuranceName { get; set; }
		public int? InsuranceTotalValue { get { return InsuranceValues.Sum(x => x.InsuranceValue); } }
	}
}
