using Microsoft.AspNetCore.Mvc;
using OganiTask.DataAccessLayer;
using OganiTask.ViewModels;

namespace OganiTask.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public ContactController(AppDbContext appdbContext)
        {
            _dbcontext = appdbContext;
        }

        public IActionResult Contact()
        {
            var widget = _dbcontext.Widget.ToList();

            ContactViewModel viewModel = new ContactViewModel
            {
                Widget = widget,
            };

            return View(viewModel);
        }
    }
}
