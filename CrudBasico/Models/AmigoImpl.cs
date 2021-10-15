using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Models
{
    public class AmigoImpl : IAmigo
    {
        List<Amigo> Lista;

        public AmigoImpl()
        {
            Lista = new List<Amigo>();
            Lista.Add(new Amigo { id = 1, nombres = "Carlos Bryan Hinostroza Araujo", correo = "Bryan@gmail.com" });
            Lista.Add(new Amigo { id = 2, nombres = "Cristian Marcelino Hinostroza Araujo", correo = "Cristian@gmail.com" });
            Lista.Add(new Amigo { id = 3, nombres = "Karen Milagros Hinostroza Araujo", correo = "Karen@gmail.com" });
        }

        public Amigo GetAmigo(int id)
        {
            return this.Lista.FirstOrDefault(x => x.id == id);
        }

        public List<Amigo> Listar()
        {
            return this.Lista;
        }
    }
}
