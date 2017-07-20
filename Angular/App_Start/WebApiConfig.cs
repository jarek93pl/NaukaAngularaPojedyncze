﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Angular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Konfiguracja i usługi składnika Web API

            // Trasy składnika Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "Scripts/angular.js",
                
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
