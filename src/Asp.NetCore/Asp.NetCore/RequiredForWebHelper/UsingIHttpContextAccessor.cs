using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Asp.NetCore.RequiredForWebHelper
{
    public class UsingIHttpContextAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsingIHttpContextAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task SendMessage(string message)
        {
            // HttpContext'a erişim sağlamak için Context kullanılır
            var userName = Context.User.Identity.Name;

            // Diğer HttpContext özelliklerine erişim

            // Örnek: Bağlı olan istemcilere mesaj gönderme
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}
