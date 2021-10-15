using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Models
{
    public interface IAmigo
    {

        List<Amigo> Listar();
        Amigo GetAmigo(int id);
    }
}
