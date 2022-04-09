using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(name: "Paginas",
                            url: "Paginas",
                            defaults: new { controller = "Paginas", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(name: "Paginas_novo",
                            url: "Paginas/novo",
                            defaults: new { controller = "Paginas", action = "Novo", id = UrlParameter.Optional });


            routes.MapRoute(name: "Paginas_criar",
                            url: "Paginas/criar",
                            defaults: new { controller = "Paginas", action = "Criar", id = UrlParameter.Optional });


            routes.MapRoute(name: "Paginas_editar",
                            url: "Paginas/editar/{id}",
                            defaults: new { controller = "Paginas", action = "Editar", id = 0 });

            routes.MapRoute(name: "Paginas_alterar",
                            url: "Paginas/alterar/{id}",
                            defaults: new { controller = "Paginas", action = "Alterar", id = 0 });

        }
    }
}
