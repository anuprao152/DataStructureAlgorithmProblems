using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using MyWebPageApp.Infrastructure;

namespace MyWebPageApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ViewEngines.Engines.Add(new CustomViewEngine());

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();

            HttpException httpexception = exception as HttpException;

            string action;
            if (httpexception != null)
            {
                
                switch (httpexception.GetHashCode())
                {
                    case 404:
                        action ="HttpError404";
                        break;
                    case 500:
                        action = "HttpError405";
                        break;
                    default:
                        action ="General";
                        break;
                       
                }
            }

            action = "HttpError404";
            Response.Redirect(string.Format("~/Error/{0}/", action));
        }

        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathinfo}");

        //    routes.MapRoute(
        //        "Defaul",
        //        "{controller}/{action}/{id}",
        //        new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
        //        );

        //}
    }
}