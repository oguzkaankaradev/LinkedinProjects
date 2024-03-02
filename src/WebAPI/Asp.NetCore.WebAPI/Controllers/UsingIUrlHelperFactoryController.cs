using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.WebAPI.Controllers
{
    public class UsingIUrlHelperFactoryController : Controller
    {
        private readonly IUrlHelper _urlHelper;

        public UsingIUrlHelperFactoryController(IUrlHelper urlHelper)
        {
            _urlHelper = urlHelper;
        }
        public IActionResult Index()
        {
            // Perform URL creation or management using the _urlHelper object
            var url = _urlHelper.Action("ActionName", "ControllerName");

            // .. 

            return View();
        }
    }
}
