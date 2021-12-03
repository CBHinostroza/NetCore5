using CrudBasico.Data;
using CrudBasico.Entidades;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Controllers
{
    public class EmpresaController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmpresaController(ApplicationDbContext context,IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("Listar")]
        public ViewResult Listar()
        {
            var list = _context.TBT_EMPRESA.ToList<TBT_EMPRESA>();
            return View(list);
        }

        [HttpGet("Crear/{id}")]
        public ViewResult Crear(int id)
        {
            var tBT_EMPRESA = _context.TBT_EMPRESA.Find(id);

            return View(tBT_EMPRESA);
        }

        [HttpGet("Crear")]
        public ViewResult Crear()
        {
            return View();
        }


        [HttpDelete("Eliminar")]
        public IActionResult Eliminar(int id)
        {
            var tBT_EMPRESA = _context.TBT_EMPRESA.Find(id);
            if (tBT_EMPRESA != null)
            {
                _context.TBT_EMPRESA.Remove(tBT_EMPRESA);
                _context.SaveChanges();
            }
            return RedirectToAction("Listar");
        }

        [HttpPut("Actualizar")]
        public TBT_EMPRESA Actualizar(TBT_EMPRESA tBT_EMPRESA)
        {
            _context.Entry(tBT_EMPRESA).State = EntityState.Modified;
            _context.SaveChanges();
            return tBT_EMPRESA;
        }

        [HttpPost("Guardar")]
        public IActionResult Guardar(TBT_EMPRESA tBT_EMPRESA)
        {

            if (tBT_EMPRESA.IDEMPRESA>0)
            {
                _context.Entry(tBT_EMPRESA).State = EntityState.Modified;
                _context.SaveChanges();
            }
            else
            {
                _context.TBT_EMPRESA.Add(tBT_EMPRESA);
                _context.SaveChanges();
            }
            return RedirectToAction("Listar");
        }

        
    }
}
