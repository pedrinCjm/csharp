using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute( //cria um link para uma página mostrando todas as notícias
                name:"Todas as Noticias", // um nome qualquer
                url:"noticias/", // a url de acesso
                defaults:new { controller = "Home", action= "TodasAsNoticias" } // a action que será chamada e a pág onde ela se encontra
                );


            routes.MapRoute( // cria um link mas categorias de notícias
                name: "Categoria Especifica",
                url: "noticias/{categoria}", // a palavra categoria sera substituída pela nome da categoria - as categorias são obtidas na home
                defaults: new { controller = "Home", action = "MostraCategoria" }
                );


            routes.MapRoute( // cria um link direto para as noticias pelo nome delas - isso ajuda o marketing da pág
                name: "Mostra Noticia",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { controller = "Home", action = "MostraNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
