using Microsoft.AspNetCore.Mvc;
using Restaurant.Infrastructure.Data;
using Restaurant.Domain.Entities;

namespace Restaurant.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly RestaurantDbContext _context;

        public ReservationController(RestaurantDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                reservation.Status = "Chờ xác nhận";
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                TempData["Success"] = "Đặt bàn thành công!";
                return RedirectToAction("Create");
            }
            return View(reservation);
        }

        public IActionResult Index()
        {
            var list = _context.Reservations.OrderByDescending(r => r.ReservationDate).ToList();
            return View(list);
        }
    }
}
