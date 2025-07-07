using Microsoft.AspNetCore.Mvc;
using Restaurant.Domain.Entities;
using Restaurant.Infrastructure.Data;

namespace Restaurant.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly RestaurantDbContext _context;

        public ContactController(RestaurantDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                message.SentAt = DateTime.Now;
                _context.ContactMessages.Add(message);
                _context.SaveChanges();
                TempData["Success"] = "Gửi liên hệ thành công!";
                return RedirectToAction("Create");
            }
            return View(message);
        }
    }
}
