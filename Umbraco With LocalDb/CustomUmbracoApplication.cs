using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;


namespace Umbraco_With_LocalDb
{
    public class CustomUmbracoApplication : UmbracoApplication
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this);
        }
    }

    public class CustomWebBootManager : WebBootManager
    {
        public CustomWebBootManager(UmbracoApplicationBase application):base(application)
        {
            //Hook into boot manager
        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute(
                "HomePage",
                "home/index",
                new {controller="Home", action="Index"}
                );

            return base.Complete(afterComplete);
        }
    }
}
