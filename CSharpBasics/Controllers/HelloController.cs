﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CSharpBasics.Controllers
{
    public class HelloController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("Hello, World");
            //throw new NotImplementedException();
        }
    }
}