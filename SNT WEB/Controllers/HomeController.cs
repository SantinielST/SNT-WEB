using Microsoft.AspNetCore.Mvc;
using SNT_WEB.Domain;

namespace SNT_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextField.GetTextFieldCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextField.GetTextFieldCodeWord("PageContacts"));
        }
    }
}
