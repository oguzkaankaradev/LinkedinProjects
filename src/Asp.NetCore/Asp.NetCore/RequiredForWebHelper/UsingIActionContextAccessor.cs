using Microsoft.AspNetCore.Mvc;

//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Asp.NetCore.RequiredForWebHelper
{
    public class UsingIActionContextAccessor
    {
        private readonly IActionContextAccessor _actionContextAccessor;

        public UsingIActionContextAccessor(IActionContextAccessor actionContextAccessor)
        {
            _actionContextAccessor = actionContextAccessor;
        }

        public void MyService()
        {
            ActionContext actionContext = _actionContextAccessor.ActionContext;
        }
    }
}
