using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;


        public HomeController() // construtor
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data); // inicializa a variáveis com níticas ordenando por data

        }

        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3); // pega as 3 últimas notícias
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList(); // obtem todas as categorias distintas

            ViewBag.Categorias = todasAsCategorias;
               
            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias() // action que mostra todas as notícias
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId)); // exibe todas as notícias com o ID relacionado
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }

    }
}