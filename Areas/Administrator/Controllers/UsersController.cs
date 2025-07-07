using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
using Restaurant.Infrastructure.Data;
using System.Security.Cryptography;
using System.Text;


namespace Restaurant.Web.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UsersController : Controller
    {
        private readonly RestaurantDbContext _context;

        public UsersController(RestaurantDbContext context)
        {
            _context = context;
        }

        private bool IsAdmin()
        {
            return HttpContext.Session.GetString("Role") == "Admin";
        }

        // GET: /Users
        public async Task<IActionResult> Index()
        {
            if (!IsAdmin())
                return RedirectToAction("AccessDenied", "Users");

            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: /Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsAdmin())
                return RedirectToAction("AccessDenied", "Users");

            if (id == null)
                return NotFound();

            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Restaurant.Domain.Entities.User user)
        {
            if (!IsAdmin())
                return RedirectToAction("AccessDenied", "Users");

            // ✅ Debug log để kiểm tra lỗi
            if (!ModelState.IsValid)
            {
                foreach (var entry in ModelState)
                {
                    Console.WriteLine($"{entry.Key}:");
                    foreach (var error in entry.Value.Errors)
                    {
                        Console.WriteLine($"    Error: {error.ErrorMessage}");
                    }
                }

                return View(user); // Trả lại form nếu dữ liệu không hợp lệ
            }

            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null)
                return NotFound();

            existingUser.FullName = user.FullName;
            existingUser.Email = user.Email;
            existingUser.Role = user.Role;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Users");
        }


        // GET: /Users/CreateStaff
        public IActionResult CreateStaff()
        {
            if (!IsAdmin())
                return RedirectToAction("AccessDenied", "Users");

            return View();
        }

        // POST: /Users/CreateStaff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStaff(Restaurant.Domain.Entities.User model)
        {
            if (!IsAdmin())
                return RedirectToAction("AccessDenied", "Users");

            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("", "Username đã tồn tại");
                    return View(model);
                }

                model.PasswordHash = HashPassword(model.PasswordHash);
                model.Role = "Staff";
                model.CreatedAt = DateTime.Now;

                _context.Users.Add(model);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: /Users/AccessDenied
        public IActionResult AccessDenied()
        {
            return View();
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
