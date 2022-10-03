using ChefApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChefApp.Controllers
{
    public class ChefController : Controller
    {
        public IActionResult ChefInfo()
        {
            List<ChefDetails> che = ChefDetails.ChefInformation();
            return View(che);
        }
    }
}
