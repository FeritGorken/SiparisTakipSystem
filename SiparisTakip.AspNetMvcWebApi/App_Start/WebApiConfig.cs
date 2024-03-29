﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SiparisTakip.AspNetMvcWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //xml to json
           // config.Formatters.Remove(config.Formatters.XmlFormatter);
           // config.Formatters.Add(config.Formatters.JsonFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
