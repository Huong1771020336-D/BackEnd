using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Infrastructure.Data;

namespace Restaurant.Web.Controllers
{
    public class GalleryController : Controller
    {
        private readonly RestaurantDbContext _context;

        public GalleryController(RestaurantDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var images = _context.GalleryImages
                .Include(g => g.Category)
                .ToList();

            return View(images); // Truyền Model vào View
        }
    }
}
