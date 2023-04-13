using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalApp.Models;

namespace MovieRentalApp.Controllers
{
    public class UsersLoginController : Controller
    {
        private readonly MovieRentalContext _context;

        public UsersLoginController(MovieRentalContext context)
        {
            _context = context;
        }
        // GET: UsersLogins
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsersLogins/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersLogins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersLogins/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersLogins/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersLogins/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersLogins/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersLogins/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Password")] UserLogin user)
        {
            var email = await _context.Users
                .FirstOrDefaultAsync(m => m.Email == user.Email);
            var password = await _context.Users
                .FirstOrDefaultAsync(m => m.Password == user.Password);
            if (email == null && password == null)
            {
                return NotFound();
            }
            else
            {
                return RedirectToAction("MovieDashboard", "Movies");
            }
            //return View();
        }
    }
}
