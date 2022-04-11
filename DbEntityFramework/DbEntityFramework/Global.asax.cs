using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DbEntityFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(Object sender,EventArgs arg)
        {
            Application.Lock();
            Application["Totalvisitor"] = Convert.ToInt32(Application["totalVisitor"]) + 1;
            Session["UserName"] = null;//registring session key with current session
            Session["LoginTime"] = null;
            Application.UnLock();
        }


        //Application_End()
        //Session_Start()
        //Application_Error()
        //Session_End()

    }

}