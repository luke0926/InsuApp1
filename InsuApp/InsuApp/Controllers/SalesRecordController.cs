﻿using InsuApp1.Data;
using InsuApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace InsuApp1.Controllers
{
    public class SalesRecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesRecordController(ApplicationDbContext context)
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
