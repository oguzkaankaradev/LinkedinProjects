using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCore.RequiredForWebHelper
{
    public class UsingIHttpContextAccessorController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsingIHttpContextAccessorController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult GetUserInfo()
        {
            HttpContext httpContext = _httpContextAccessor.HttpContext;
            
            string userName = httpContext.User.Identity.Name;

            string message = httpContext.Request.PathBase;

            return Ok($"Current user: {userName}");

        }

        //Middleware
        public class HttpContextAccessorMiddleware
        {
            public Task InvokeAsync(HttpContext context)
            {
                //
                return Task.CompletedTask;
            }
        }

        //Access HttpContext from SignalR
        

    }
}
