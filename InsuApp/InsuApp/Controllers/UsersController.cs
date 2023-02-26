using InsuApp1.Data;
using InsuApp1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using X.PagedList;


namespace InsuApp1.Controllers
{

    public class UsersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users + Pagination setup
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 6;
            var clientList = _context.User.OrderBy(x => x.LastName).ToPagedList(pageNumber, pageSize);
            return View(clientList);
        }

        // GET: Users/Details/5
        [HttpGet]
        [Authorize(Roles = "admin, user")]
        //[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.ID = id;

            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            User? user = await _context.User
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            UserDetailViewModel viewModel = await GetUserDetailViewModelFromUser(user);

            return View(viewModel);
        }

        // GET: User Insured Event Form
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> InsuredEventForm(int? id)
        {
            if (id == null)
            {
                return NotFound("User Insured Event Form does not found!");
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound("User Insured Event Form does not found!*");
            }

            UserDetailViewModelEvent viewModelEvent = await GetUserDetailViewModelEvent(user);
            viewModelEvent.MainInsuEventList = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName");

            return PartialView("InsuredEventForm", viewModelEvent);
        }

        // POST: Insured Event Form POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsuredEventFormCreate([Bind("UserDetailEventId,MainInsuredEventName,InsuredEventValue,ObjectOfInsuredEvent,InsuredEventDate")] UserDetailViewModelEvent viewModelEvent)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserInsuredEvent userInsuredEvent = new UserInsuredEvent();

                    userInsuredEvent.InsuredEventName = viewModelEvent.MainInsuredEventName;
                    userInsuredEvent.InsuredEventValue = viewModelEvent.InsuredEventValue;
                    userInsuredEvent.ObjectOfInsuredEvent = viewModelEvent.ObjectOfInsuredEvent;
                    userInsuredEvent.InsuredEventDate = viewModelEvent.InsuredEventDate;

                    User user = await _context.User.FirstOrDefaultAsync(m => m.UserId == viewModelEvent.UserDetailEventId);

                    if (user == null)
                    {
                        return NotFound("Form saving error!");
                    }

                    userInsuredEvent.UserUserInsuredEvent = user;
                    _context.UserInsuredEvent.Add(userInsuredEvent);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Insured Event Created Successfully!";

                    viewModelEvent = await GetUserDetailViewModelEvent(user);
                    viewModelEvent.MainInsuEventList = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName");

                    return PartialView("InsuredEventForm", viewModelEvent);
                }
                catch
                {
                    viewModelEvent.MainInsuEventList = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName");
                    return PartialView("InsuredEventForm", viewModelEvent);
                }
            }
            else
            {
                viewModelEvent.MainInsuEventList = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName");
                return PartialView("InsuredEventForm", viewModelEvent);
            }
        }

        // GET: User Insurance Form
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> InsuranceForm(int? id)
        {
            if (id == null)
            {
                return NotFound("User Insurance Form does not found!");
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound("User Insurance Form does not found!*");
            }

            UserDetailViewModel viewModel = await GetUserDetailViewModelFromUser(user);
            viewModel.MainInsuList = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName");

            return PartialView("InsuranceForm", viewModel);
        }

        // POST: Insurance Form POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsuranceFormCreate([Bind("UserDetailViewId,MainInsuranceName,InsuranceValue,ObjectOfInsurane,InsuranceValidFrom,InsuranceValidTo")] UserDetailViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserInsurance userInsurance = new UserInsurance();

                    userInsurance.InsuranceName = viewModel.MainInsuranceName;
                    userInsurance.InsuranceValue = viewModel.InsuranceValue;
                    userInsurance.ObjectOfInsurance = viewModel.ObjectOfInsurane;
                    userInsurance.InsuranceValidFrom = viewModel.InsuranceValidFrom;
                    userInsurance.InsuranceValidTo = viewModel.InsuranceValidTo;

                    User user = await _context.User.FirstOrDefaultAsync(m => m.UserId == viewModel.UserDetailViewId);

                    if (user == null)
                    {
                        return NotFound("Form saving error!");
                    }

                    userInsurance.UserUserInsurance = user;
                    _context.UserInsurance.Add(userInsurance);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Insurance Created Successfully!";

                    viewModel = await GetUserDetailViewModelFromUser(user);
                    viewModel.MainInsuList = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName");

                    //ViewData["MainInsurance"] = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName", selectedValue: _context.MainInsurance);

                    return PartialView("InsuranceForm", viewModel);
                }
                catch
                {
                    viewModel.MainInsuList = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName");
                    return PartialView("InsuranceForm", viewModel);
                }
            }
            else
            {
                viewModel.MainInsuList = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName");
                return PartialView("InsuranceForm", viewModel);
            }
        }

        // GET: Users/Create
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            User user = new User();

            return PartialView("Create", user);
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        /*public IActionResult Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            TempData["AlertMessage"] = "Client Created Succesfully!";
            return PartialView("Create", user);
        }*/

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(user);
                    _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Client Created Successfully!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound("User Creation Error!");
                    }
                    else
                    {
                        throw;
                    }
                }
                return PartialView("Create", user);
            }
            return PartialView("Create", user);
        }

        // GET: Users/Edit/5
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int? id)
        {
            ViewBag.ID = id;
            var user = _context.User.Where(x => x.UserId == id).FirstOrDefault();

            return PartialView("Edit", user);
        }

        /*public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }*/

        //GET: User Insured Event/Edit/5
        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> EditUserInsuredEvent(int? id)
        {

            if (id == null || _context.UserInsuredEvent == null)
            {
                return NotFound("User Insured Event Detail Page Error!");
            }

            var userInsuredEvent = await _context.UserInsuredEvent.FindAsync(id);
            if (userInsuredEvent == null)
            {
                return NotFound("User Insured Event Detail Page Error!*");
            }

            ViewData["MainInsuredEvent"] = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName", selectedValue: _context.MainInsuredEvent);

            return PartialView("EditUserInsuredEvent", userInsuredEvent);
        }

        //GET: UserInsurance/Edit/5
        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> EditUserInsurance(int? id)
        {

            if (id == null || _context.UserInsurance == null)
            {
                return NotFound("User Insurance Detail Page Error!");
            }

            var userInsurance = await _context.UserInsurance.FindAsync(id);
            if (userInsurance == null)
            {
                return NotFound("User Insurance Detail Page Error!*");
            }

            ViewData["MainInsurance"] = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName", selectedValue: _context.MainInsurance);

            return PartialView("EditUserInsurance", userInsurance);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.User.Update(user);
                    _context.SaveChanges();
                    TempData["AlertMessage"] = "Client Updated Successfully!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound("User Edit Error!");
                    }
                    else
                    {
                        throw;
                    }
                }
                return PartialView("Edit", user);
            }
            return PartialView("Edit", user);
        }

        //[ValidateAntiForgeryToken]
        /*public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,EmailAddress,PhoneNumber,StreetAddress,City,PostalCode")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View( user);
        }*/

        //POST: User Insured Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserInsuredEvent(int id, [Bind("UserInsuredEventId,InsuredEventName,InsuredEventValue,ObjectOfInsuredEvent,InsuredEventDate")] UserInsuredEvent userInsuredEvent)
        {
            if (id != userInsuredEvent.UserInsuredEventId)
            {
                return NotFound("User Insured Event Editing Error!");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInsuredEvent);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Insured Event Updated Successfully!";
                }
                catch
                {
                    ViewData["MainInsuredEvent"] = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName", selectedValue: _context.MainInsuredEvent);
                }
            }
            else
            {
                ViewData["MainInsuredEvent"] = new SelectList(_context.MainInsuredEvent, "MainInsuredEventName", "MainInsuredEventName", selectedValue: _context.MainInsuredEvent);
            }
            return PartialView("EditUserInsuredEvent", userInsuredEvent);
        }

        //POST: UserInsurance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserInsurance(int id, [Bind("UserInsuranceId,InsuranceName,InsuranceValue,ObjectOfInsurance,InsuranceValidFrom,InsuranceValidTo")] UserInsurance userInsurance)
        {
            if (id != userInsurance.UserInsuranceId)
            {
                return NotFound("User Insurance Editing Error!");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInsurance);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Insurance Updated Successfully!";
                }
                catch
                {
                    ViewData["MainInsurance"] = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName", selectedValue: _context.MainInsurance);
                }
            }
            else
            {
                ViewData["MainInsurance"] = new SelectList(_context.MainInsurance, "MainInsuranceName", "MainInsuranceName", selectedValue: _context.MainInsurance);
            }
            return PartialView("EditUserInsurance", userInsurance);
        }

        // GET: Users/Delete/5
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return PartialView("Delete", user);
        }

        //GET: User Insured Event/Delete/5
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteUserInsuredEvent(int? id)
        {
            if (id == null || _context.UserInsuredEvent == null)
            {
                return NotFound("User Insured Event Delete Action Error!");
            }

            var userInsuredEvent = await _context.UserInsuredEvent
                .FirstOrDefaultAsync(m => m.UserInsuredEventId == id);
            if (userInsuredEvent == null)
            {
                return NotFound("User Insured Event Delete Action Error!*");
            }

            return PartialView("DeleteUserInsuredEvent", userInsuredEvent);
        }

        //GET: User Insurance/Delete/5
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteUserInsurance(int? id)
        {
            if (id == null || _context.UserInsurance == null)
            {
                return NotFound("User Insurance Delete Action Error!");
            }

            var userInsurance = await _context.UserInsurance
                .FirstOrDefaultAsync(m => m.UserInsuranceId == id);
            if (userInsurance == null)
            {
                return NotFound("User Insurance Delete Action Error!*");
            }

            return PartialView("DeleteUserInsurance", userInsurance);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.User == null)
            {
                return Problem("Entity set 'ApplicationDbContext.User' is null.");
            }
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
            }

            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Client Account Deleted Successfully!";

            return PartialView("Delete", user);
        }

        //POST: User Insured Event Post Method
        [HttpPost, ActionName("DeleteUserInsuredEvent")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmedEventDelete(int id)
        {
            if (_context.UserInsuredEvent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users' is null.");
            }
            var userInsuredEvent = await _context.UserInsuredEvent.FindAsync(id);
            if (userInsuredEvent != null)
            {
                _context.UserInsuredEvent.Remove(userInsuredEvent);
            }

            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Insured Event Deleted Successfully!";

            return PartialView("DeleteUserInsuredEvent", userInsuredEvent);
        }

        //POST: UserInsurance Post Method
        [HttpPost, ActionName("DeleteUserInsurance")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirmed(int id)
        {
            if (_context.UserInsurance == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users' is null.");
            }
            var userInsurance = await _context.UserInsurance.FindAsync(id);
            if (userInsurance != null)
            {
                _context.UserInsurance.Remove(userInsurance);
            }

            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Insurance Deleted Successfully!";

            return PartialView("DeleteUserInsurance", userInsurance);
        }
        // User Detail ViewModel 
        private async Task<UserDetailViewModel> GetUserDetailViewModelFromUser(User user)
        {
            UserDetailViewModel viewModel = new UserDetailViewModel();
            viewModel.UserDetailView = user;
            viewModel.UserDetailViewId = user.UserId;
            viewModel.UserCategory = user.UserCategory;

            List<UserInsurance> userInsurances = await _context.UserInsurance.Where(m => m.UserUserInsurance == user).ToListAsync();
            viewModel.UserInsurances = userInsurances;

            List<UserInsuredEvent> userInsuredEvents = await _context.UserInsuredEvent.Where(m => m.UserUserInsuredEvent == user).ToListAsync();
            viewModel.UserInsuredEvents = userInsuredEvents;

            /*List<UserInsuredEvent> userInsuredEvents = await _context.UserInsuredEvent.Where(m => m.UserUserInsuredEvent == user).ToListAsync();
            viewModel.UserInsuredEvents= userInsuredEvents;*/

            //MainInsurance mainInsurance = new MainInsurance();
            //List<MainInsurance> mainInsurances = await _context.MainInsurance.Where(m => m.UserMainInsurance == user).ToListAsync();
            //viewModel.InsuranceName = mainInsurance.MainInsuranceName;
            //viewModel.MainInsurances = mainInsurances;

            return viewModel;
        }

        //User Insured Event ViewModel
        private async Task<UserDetailViewModelEvent> GetUserDetailViewModelEvent(User user)
        {
            UserDetailViewModelEvent viewModelEvent = new UserDetailViewModelEvent();
            viewModelEvent.UserDetailEventView = user;
            viewModelEvent.UserDetailEventId = user.UserId;
            viewModelEvent.UserCategory = user.UserCategory;

            List<UserInsuredEvent> userInsuredEvents = await _context.UserInsuredEvent.Where(m => m.UserUserInsuredEvent == user).ToListAsync();
            viewModelEvent.UserInsuredEvents = userInsuredEvents;

            return viewModelEvent;
        }

        private bool UserExists(int id)
        {
            return (_context.User?.Any(e => e.UserId == id)).GetValueOrDefault();
        }

        private bool ProductExists(int id)
        {
            return (_context.UserInsurance?.Any(e => e.UserInsuranceId == id)).GetValueOrDefault();
        }
    }
}

