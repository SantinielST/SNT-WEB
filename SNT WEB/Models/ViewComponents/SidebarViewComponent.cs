using Microsoft.AspNetCore.Mvc;
using SNT_WEB.Domain;
using System.Threading.Tasks;

namespace SNT_WEB.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItem()));
        }
    }
}
