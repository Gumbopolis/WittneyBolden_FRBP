using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GlobalAnomaliesAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        /// <summary>
        ///  Add the Access-Control-Allow-Origin header.  This API only provides GET access and returns a pred-defined set of data
        /// </summary>
        // Allow cross-origin access.  GET is the only action allowed in this application and i
        protected void Application_BeginRequest()
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        }
    }
}

