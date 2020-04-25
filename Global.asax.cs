using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace url_shortner
{
    public class Global : HttpApplication
    {
        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("preview", "{ShortLink}", "~/redirect.aspx");
        }
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}