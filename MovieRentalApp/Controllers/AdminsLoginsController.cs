using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalApp.Models;

namespace MovieRentalApp.Controllers
{
    public class AdminsLoginsController : Controller
    {
        private readonly MovieRentalContext _context;

        public AdminsLoginsController(MovieRentalContext context)
        {
            _context = context;
        }
        // GET: AdminsLoginsController
        public ActionResult Index()
        {
            return View();
        }

        //POST 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username,Password")]AdminsLogin admin)
        {
            var username = await _context.Admins
                .FirstOrDefaultAsync(m => m.Username == admin.Username);
            var password = await _context.Admins
                .FirstOrDefaultAsync(m => m.Password == admin.Password);
            if (username==null && password==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Movies");
            }
            //return View();
        }

        // GET: AdminsLoginsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminsLoginsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminsLoginsController/Create
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

        // GET: AdminsLoginsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminsLoginsController/Edit/5
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

        // GET: AdminsLoginsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminsLoginsController/Delete/5
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
    }
}
