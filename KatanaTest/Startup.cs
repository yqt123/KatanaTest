using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(KatanaTest.Startup))]
namespace KatanaTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World");
            });

            //app.UseNancy();

            //var config = new HttpConfiguration();
            //config.MapHttpAttributeRoutes();
            //config.Routes.MapHttpRoute("bugs", "api/{Controller}");
            //app.UseWebApi(config);

        }
    }
}