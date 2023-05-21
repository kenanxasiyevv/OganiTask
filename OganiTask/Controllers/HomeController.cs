using Microsoft.AspNetCore.Mvc;
using OganiTask.DataAccessLayer;
using OganiTask.DataAccessLayer.Entities;
using OganiTask.ViewModels;

namespace OganiTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public HomeController(AppDbContext appdbContext)
        {
            _dbcontext = appdbContext;
        }

        public IActionResult Index()
        {
            var category = _dbcontext?.Categories?.ToList();
            var products = _dbcontext?.Products?.ToList();
            var blogs = _dbcontext?.Blogs?.ToList();

            var viewModel = new HomeViewModel
            {
                Categories = category,
                Products = products,
                Blogs = blogs,
            };

            return View(viewModel);
        }
    }
}
