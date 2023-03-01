using InsuApp1.Data;
using Microsoft.AspNetCore.Mvc;

namespace InsuApp1.Controllers
{
    public class SalesRecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesRecordController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();

            List<string?> labels = _context.UserInsurance.Select(p=> p.InsuranceName).ToList();

            data.Add(labels);

            List<int?> insuranceValue = _context.UserInsurance.Select(p=> p.InsuranceValue).ToList();
            data.Add(insuranceValue);

            return data;
        }
    }
}
