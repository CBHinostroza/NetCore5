using CrudBasico.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Controllers
{
    public class HomeController : Controller
    {
        private IAmigo metodos;
        //private IAmigo metodos = new AmigoImpl();

        public HomeController(IAmigo metodos)
        {
            this.metodos = metodos;
        }


        public ViewResult Index()
        {
            return View(metodos.Listar());
        }

        [Route("Home/Details/{id?}")]
        [HttpGet]
        public ViewResult Details(int? id)
        {
            /*si es nulo, forzamos a que busque los
             detalles del amigo 1*/
            Amigo amigo = metodos.GetAmigo(id??2);
            return View(amigo);
        }


        [Route("Home/Create")]
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [Route("Home/Create")]
        [HttpPost]
        public RedirectToActionResult Create(Amigo a)
        {
            Amigo amigo = metodos.Nuevo(a);
            /*Redigirmos a la vista detalle y le pasamos el parametro id*/
            return RedirectToAction("details", new { id = amigo.id });
        }


        public List<Amigo> Lista()
        {
            return metodos.Listar();
        }

        public Amigo GetAmigo()
        {
            var amigo = metodos.GetAmigo(2);

            return amigo;
        }

    }
}
