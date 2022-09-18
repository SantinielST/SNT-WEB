using Microsoft.AspNetCore.Mvc;
using SNT_WEB.Domain;
using SNT_WEB.Domain.Entities;
using SNT_WEB.Service;

namespace SNT_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextField.GetTextFieldCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextField.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
