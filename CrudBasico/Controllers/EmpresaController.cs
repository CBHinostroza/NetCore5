using CrudBasico.Data;
using CrudBasico.Entidades;
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

        
        [HttpGet("ListarTodos")]
        public List<TBT_EMPRESA> Listar()
        {
            return _context.TBT_EMPRESA.ToList<TBT_EMPRESA>();
        }

        [Route("ListarPorEmpresa/{id}")]
        public TBT_EMPRESA ListarPorEmpresa(int id)
        {
            var tBT_EMPRESA = _context.TBT_EMPRESA.Find(id);

            return tBT_EMPRESA;
        }

        [HttpDelete]
        public TBT_EMPRESA Eliminar(int id)
        {
            var tBT_EMPRESA = _context.TBT_EMPRESA.Find(id);
            if (tBT_EMPRESA != null)
            {
                _context.TBT_EMPRESA.Remove(tBT_EMPRESA);
                _context.SaveChanges();
            }
            return tBT_EMPRESA;
        }
        [HttpPut]
        public TBT_EMPRESA Actualizar(TBT_EMPRESA tBT_EMPRESA)
        {
            _context.Entry(tBT_EMPRESA).State = EntityState.Modified;
            _context.SaveChanges();
            return tBT_EMPRESA;
        }
        [HttpPost]
        public TBT_EMPRESA Guardar(TBT_EMPRESA tBT_EMPRESA)
        {
            _context.TBT_EMPRESA.Add(tBT_EMPRESA);
            _context.SaveChanges();
            return tBT_EMPRESA;
        }
    }
}
