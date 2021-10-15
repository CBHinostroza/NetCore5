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

        private IAmigo metodos = new AmigoImpl();

        public ViewResult Index()
        {
            return View(metodos.Listar());
        }

        public ViewResult Details(int? id)
        {
            var amigo = metodos.GetAmigo(id??1);

            return View(amigo);
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
