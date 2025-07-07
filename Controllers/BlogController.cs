using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Infrastructure.Data;

namespace Restaurant.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly RestaurantDbContext _context;

        public BlogController(RestaurantDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.BlogPosts
                .Include(p => p.Category)
                .OrderByDescending(p => p.PostedAt)
                .ToList();

            return View(posts); // 👈 truyền danh sách vào View
        }

        public IActionResult Details(int id)
        {
            var post = _context.BlogPosts
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}
