using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MyWebPageApp.Infrastructure
{
    //Custome Role based Autorization Filter
    public class CustomRoleBaseAuth : AuthorizeAttribute
    {
        private Boolean Authorized = false;
        private string role = string.Empty;

        public CustomRoleBaseAuth(string role)
        {
            role = this.role;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            IPrincipal user = HttpContext.Current.User;
            if (user.Identity.IsAuthenticated)
            {
                if (user.IsInRole("XXX"))
                {
                    Authorized = true;
                }
            }
            if (!Authorized)
            {
                httpContext.Response.Write("You need XXX Role to access this resource");  
            }

            return Authorized;
        }
    }
}