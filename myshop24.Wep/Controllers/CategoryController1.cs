using Microsoft.AspNetCore.Mvc;
using myshop24.Web.Data;

namespace myshop24.Wep.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController1(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Categories = _context.Categories.ToList();
            return View();
        }
    }
}
