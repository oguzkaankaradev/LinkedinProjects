using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
