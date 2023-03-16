using InsuApp1.Data;
using InsuApp1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuApp1.Controllers
{
    [Authorize(Roles = "admin")]
    public class MainInsurancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainInsurancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MainInsurances
        public async Task<IActionResult> Index()
        {
            return _context.MainInsurance != null ?
                        View(await _context.MainInsurance.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.MainInsurance'  is null.");
        }

        // GET: MainInsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MainInsurance == null)
            {
                return NotFound();
            }

            var mainInsurance = await _context.MainInsurance
                .FirstOrDefaultAsync(m => m.MainInsuranceId == id);
            if (mainInsurance == null)
            {
                return NotFound();
            }

            return View(mainInsurance);
        }

        // GET: MainInsurances/Create
        public IActionResult Create()
        {
            MainInsurance mainInsurance = new MainInsurance();

            return PartialView("Create", mainInsurance);
        }

        // POST: MainInsurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MainInsuranceId,MainInsuranceName")] MainInsurance mainInsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainInsurance);
                await _context.SaveChangesAsync();
                TempData["AlertMessage"] = "Pojištění úspěšně založeno!";

                return PartialView("Create", mainInsurance);
            }
            return PartialView("Create", mainInsurance);
        }

        // GET: MainInsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MainInsurance == null)
            {
                return NotFound();
            }

            var mainInsurance = await _context.MainInsurance.FindAsync(id);
            if (mainInsurance == null)
            {
                return NotFound();
            }
            return PartialView("Edit", mainInsurance);
        }

        // POST: MainInsurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MainInsuranceId,MainInsuranceName")] MainInsurance mainInsurance)
        {
            if (id != mainInsurance.MainInsuranceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainInsurance);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Pojištění úspěšně aktualizováno!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainInsuranceExists(mainInsurance.MainInsuranceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return PartialView("Edit", mainInsurance);
            }
            return PartialView("Edit", mainInsurance);
        }

        // GET: MainInsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MainInsurance == null)
            {
                return NotFound();
            }

            var mainInsurance = await _context.MainInsurance
                .FirstOrDefaultAsync(m => m.MainInsuranceId == id);
            if (mainInsurance == null)
            {
                return NotFound();
            }

            return PartialView("Delete", mainInsurance);
        }

        // POST: MainInsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MainInsurance == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MainInsurance'  is null.");
            }
            var mainInsurance = await _context.MainInsurance.FindAsync(id);
            if (mainInsurance != null)
            {
                _context.MainInsurance.Remove(mainInsurance);
            }

            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Pojištění úspěšně odstraněno!";

            return PartialView("Delete", mainInsurance);
        }

        private bool MainInsuranceExists(int id)
        {
            return (_context.MainInsurance?.Any(e => e.MainInsuranceId == id)).GetValueOrDefault();
        }
    }
}
