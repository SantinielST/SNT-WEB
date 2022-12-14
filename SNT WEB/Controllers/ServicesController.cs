using Microsoft.AspNetCore.Mvc;
using SNT_WEB.Domain;
using System;

namespace SNT_WEB.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextField.GetTextFieldCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItem());
        }
    }
}
