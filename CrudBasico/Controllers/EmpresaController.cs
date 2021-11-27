using CrudBasico.Data;
using CrudBasico.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Controllers
{
    public class EmpresaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TBT_EMPRESA Guardar(TBT_EMPRESA tBT_EMPRESA)
        {
            _context.TBT_EMPRESA.Add(tBT_EMPRESA);
            _context.SaveChanges();
            return tBT_EMPRESA;
        }
    }
}
