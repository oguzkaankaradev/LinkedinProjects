using Core.Base.Domain.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public partial class WebHelper : IWebHelper
    {
        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly Lazy<IStoreContext> _storeContext;

        public WebHelper(IActionContextAccessor actionContextAccessor, 
            IHostApplicationLifetime hostApplicationLifetime, 
            IHttpContextAccessor httpContextAccessor, 
            IUrlHelperFactory urlHelperFactory, Lazy<IStoreContext> storeContext)

        {
            _actionContextAccessor = actionContextAccessor;
            _hostApplicationLifetime = hostApplicationLifetime;
            _httpContextAccessor = httpContextAccessor;
            _urlHelperFactory = urlHelperFactory;
            _storeContext = storeContext;
        }

        public bool IsRequestBeingRedirected => throw new NotImplementedException();

        public bool IsPostBeingDone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetCurrentIpAddress()
        {
            throw new NotImplementedException();
        }

        public string GetCurrentRequestProtocol()
        {
            throw new NotImplementedException();
        }

        public string GetRawUrl(HttpRequest request)
        {
            throw new NotImplementedException();
        }

        public string GetStoreHost(bool useSsl)
        {
            throw new NotImplementedException();
        }

        public string GetStoreLocation(bool? useSsl = null)
        {
            throw new NotImplementedException();
        }

        public string GetThisPageUrl(bool includeQueryString, bool? useSsl = null, bool lowercaseUrl = false)
        {
            throw new NotImplementedException();
        }

        public virtual string GetUrlReferrer()
        {
            if (!IsRequestAvailable())
                return string.Empty;

            return _httpContextAccessor.HttpContext.Request.Headers[HeaderNames.Referer];

        }

        protected virtual bool IsRequestAvailable()
        {
            if (_httpContextAccessor?.HttpContext == null)
                return false;

            try
            {
                if(_httpContextAccessor.HttpContext.Request == null)
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public bool IsAjaxRequest(HttpRequest request)
        {
            throw new NotImplementedException();
        }

        public bool IsCurrentConnectionSecured()
        {
            throw new NotImplementedException();
        }

        public bool IsLocalRequest(HttpRequest req)
        {
            throw new NotImplementedException();
        }

        public bool IsStaticResource()
        {
            throw new NotImplementedException();
        }

        public string ModifyQueryString(string url, string key, params string[] values)
        {
            throw new NotImplementedException();
        }

        public T QueryString<T>(string name)
        {
            throw new NotImplementedException();
        }

        public string RemoveQueryString(string url, string key, string value = null)
        {
            throw new NotImplementedException();
        }

        public void RestartAppDomain()
        {
            throw new NotImplementedException();
        }
    }
}
