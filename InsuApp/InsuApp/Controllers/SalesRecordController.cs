using InsuApp1.Data;
using InsuApp1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Data;

namespace InsuApp1.Controllers
{
    public class SalesRecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesRecordController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// User Insurance Sales Data
        /// </summary>
        /// <returns>User Insurance Sales data View</returns>
        [Authorize(Roles = "admin")]
        public IActionResult ShowSalesData()
        {
            return View();
        }

        /// <summary>
        /// User Insurance Sales Data
        /// </summary>
        /// <returns>List of User Insurance by it's name and total value</returns>
        [HttpPost]
        [Authorize(Roles = "admin")]
        public List<object> GetSalesData()
        {

            List<ChartValue> chartValue = _context.UserInsurance
                .GroupBy(s => s.InsuranceName)
                .Select(valueByInsurance => new ChartValue
                {
                    UserInsuranceName = valueByInsurance.Key,
                    ChartValueTotal = valueByInsurance.Sum(s => s.InsuranceValue)
                }).ToList();

            List<object> data = new List<object>();

            List<string?> labels = chartValue.Select(s => s.UserInsuranceName).ToList();

            data.Add(labels);

            List<int?> insuranceValue = chartValue.Select(s => s.ChartValueTotal).ToList();

            data.Add(insuranceValue);

            return data;
        }
    }
}
