using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Models
{
    public class Amigo
    {


        public int id { get; set; }
        public string nombres { get; set; }

        public string correo { get; set; }

        public Provincia provincia { get; set; }

        public Amigo()
        {
        }
        public Amigo(int id, string nombres, string correo, Provincia provincia)
        {
            this.id = id;
            this.nombres = nombres;
            this.correo = correo;
            this.provincia = provincia;
        }
    }
}
