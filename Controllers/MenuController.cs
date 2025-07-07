using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Infrastructure.Data; // namespace chứa DbContext
using Restaurant.Domain.Entities;

public class MenuController : Controller
{
    private readonly RestaurantDbContext _context;

    public MenuController(RestaurantDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var items = _context.FoodItems.ToList(); // lấy danh sách món ăn
        return View(items); // truyền vào View
    }
}
