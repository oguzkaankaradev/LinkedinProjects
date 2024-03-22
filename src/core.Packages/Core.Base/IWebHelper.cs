using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Base
{
    public partial interface IWebHelper
    {
        string GetUrlReferrer();
        string GetCurrentIpAddress();
        string GetThisPageUrl(bool includeQueryString, bool? useSsl = null, bool lowercaseUrl = false);
        bool IsCurrentConnectionSecured();
        string GetStoreHost(bool useSsl);
        string GetStoreLocation(bool? useSsl = null);
        bool IsStaticResource();
        string ModifyQueryString(string url, string key, params string[] values);
        string RemoveQueryString(string url, string key, string value = null);
        T QueryString<T>(string name);
        void RestartAppDomain();
        bool IsRequestBeingRedirected { get; }
        bool IsPostBeingDone { get; set; }
        string GetCurrentRequestProtocol();
        bool IsLocalRequest(HttpRequest req);
        string GetRawUrl(HttpRequest request);
        bool IsAjaxRequest(HttpRequest request);
    }
}
