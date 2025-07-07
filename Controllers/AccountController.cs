using Microsoft.AspNetCore.Mvc;
using Restaurant.Infrastructure.Data;
using Restaurant.Domain.Entities;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Restaurant.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly RestaurantDbContext _context;

        public AccountController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra trùng username
                if (_context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("", "Username đã tồn tại");
                    return View(model);
                }

                // Hash password và lưu người dùng
                model.PasswordHash = HashPassword(model.PasswordHash);
                model.Role = "Customer";
                model.CreatedAt = DateTime.Now;

                _context.Users.Add(model);
                _context.SaveChanges();

                // ✅ TỰ ĐỘNG ĐĂNG NHẬP
                HttpContext.Session.SetString("UserId", model.Id.ToString());
                HttpContext.Session.SetString("Username", model.Username);
                HttpContext.Session.SetString("Role", model.Role);

                // ✅ Chuyển hướng theo vai trò
                return RedirectToRoleHome(model.Role);
            }

            return View(model);
        }

        // ➕ Thêm phương thức hỗ trợ điều hướng theo Role
        private IActionResult RedirectToRoleHome(string role)
        {
            if (role == "Admin")
                return RedirectToAction("Index", "Users", new { area = "Administrator" }); // ✅ PHẢI CÓ area
            else if (role == "Staff")
                return RedirectToAction("Index", "Reservations", new { area = "Staff" }); // nếu có
            else
                return RedirectToAction("Index", "Home"); // khách
        }




        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var passwordHash = HashPassword(password);
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);

            if (user == null)
            {
                ViewBag.Error = "Sai thông tin đăng nhập";
                ViewBag.Username = username; // giữ lại tên đã nhập
                return View();
            }

            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            return RedirectToRoleHome(user.Role);
        }


        // GET: /Account/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
