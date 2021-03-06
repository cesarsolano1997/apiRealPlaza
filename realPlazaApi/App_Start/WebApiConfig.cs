using realPlazaApi.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace realPlazaApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y habilitación de CORS
            config.EnableCors();

            // Configuración de validación del token jwt
            config.MessageHandlers.Add(new TokenValidationHandler());

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
