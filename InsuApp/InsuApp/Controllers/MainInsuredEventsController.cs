using InsuApp1.Data;
using InsuApp1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuApp1.Controllers
{
    [Authorize(Roles = "admin")]
    public class MainInsuredEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainInsuredEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MainInsuredEvents
        public async Task<IActionResult> Index()
        {
            return _context.MainInsuredEvent != null ?
                        View(await _context.MainInsuredEvent.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.MainInsuredEvent'  is null.");
        }

        // GET: MainInsuredEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MainInsuredEvent == null)
            {
                return NotFound();
            }

            var mainInsuredEvent = await _context.MainInsuredEvent
                .FirstOrDefaultAsync(m => m.MainInsuredEventId == id);
            if (mainInsuredEvent == null)
            {
                return NotFound();
            }

            return View(mainInsuredEvent);
        }

        // GET: MainInsuredEvents/Create
        public IActionResult Create()
        {
            MainInsuredEvent mainInsuredEvent = new MainInsuredEvent();

            return PartialView("Create", mainInsuredEvent);
        }

        // POST: MainInsuredEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MainInsuredEventId,MainInsuredEventName")] MainInsuredEvent mainInsuredEvent)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(mainInsuredEvent);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Pojistná údálost úspěšně založena!";

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainInsuredEventExists(mainInsuredEvent.MainInsuredEventId))
                    {
                        return NotFound("Insured Event Creation Error!");
                    }
                    else
                    {
                        throw;
                    }

                }
                return PartialView("Create", mainInsuredEvent);
            }
            return PartialView("Create", mainInsuredEvent);
        }

        // GET: MainInsuredEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MainInsuredEvent == null)
            {
                return NotFound();
            }

            var mainInsuredEvent = await _context.MainInsuredEvent.FindAsync(id);
            if (mainInsuredEvent == null)
            {
                return NotFound();
            }
            return PartialView("Edit", mainInsuredEvent);
        }

        // POST: MainInsuredEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MainInsuredEventId,MainInsuredEventName")] MainInsuredEvent mainInsuredEvent)
        {
            if (id != mainInsuredEvent.MainInsuredEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainInsuredEvent);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Pojistná údálost úspěšně aktualizována!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainInsuredEventExists(mainInsuredEvent.MainInsuredEventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return PartialView("Edit", mainInsuredEvent);
            }
            return PartialView("Edit", mainInsuredEvent);
        }

        // GET: MainInsuredEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MainInsuredEvent == null)
            {
                return NotFound();
            }

            var mainInsuredEvent = await _context.MainInsuredEvent
                .FirstOrDefaultAsync(m => m.MainInsuredEventId == id);
            if (mainInsuredEvent == null)
            {
                return NotFound();
            }

            return PartialView("Delete", mainInsuredEvent);
        }

        // POST: MainInsuredEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MainInsuredEvent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MainInsuredEvent'  is null.");
            }
            var mainInsuredEvent = await _context.MainInsuredEvent.FindAsync(id);
            if (mainInsuredEvent != null)
            {
                _context.MainInsuredEvent.Remove(mainInsuredEvent);
            }

            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Pojistná událost úspěšně odstraněna!";

            return PartialView("Delete", mainInsuredEvent);
        }

        private bool MainInsuredEventExists(int id)
        {
            return (_context.MainInsuredEvent?.Any(e => e.MainInsuredEventId == id)).GetValueOrDefault();
        }
    }
}
