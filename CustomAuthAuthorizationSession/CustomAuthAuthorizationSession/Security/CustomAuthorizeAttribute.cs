using CustomAuthAuthorizationSession.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomAuthAuthorizationSession.Security
{
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" }));
            }
            else
            {
                AccountModal accountModel = new AccountModal();
                CustomPrincipal customPrincipal = new CustomPrincipal(accountModel.find(SessionPersister.Username));
                if (!customPrincipal.IsInRole(Roles))
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" }));
                }
            }
        }
    }
}