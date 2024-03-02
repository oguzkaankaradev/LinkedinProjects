using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCore.RequiredForWebHelper
{
    public class UsingIUrlServiceFactory
    {
        private readonly IUrlHelper _urlHelper;

        public UsingIUrlServiceFactory(IUrlHelperFactory urlHelperFactory, ActionContext actionContext)
        {
            _urlHelper = urlHelperFactory.GetUrlHelper(actionContext);
        }

        public string GetUrl()
        {
            // Perform URL creation or management using the _urlHelper object
            var url = _urlHelper.Action("ActionName", "ControllerName");

            // ...

            return url;
        }
    }
}
