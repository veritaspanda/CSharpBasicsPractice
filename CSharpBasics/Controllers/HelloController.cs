using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CSharpBasics.Controllers
{
    public class HelloController : Controller
    {

        public string SayHello()
        {
            return "Hello, World! v2.0";
        }

        //To use the below, change 'Controller' to 'IController and remove the Action call from SayHello MapRoute
        //public void Execute(RequestContext requestContext)
        //{
        //    requestContext.HttpContext.Response.Write("Hello, World");
        //}
    }
}