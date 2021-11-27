using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Models
{
    public class AmigoImpl : IAmigo
    {
        private List<Amigo> Lista;

        public AmigoImpl()
        {
            Lista = new List<Amigo>();
            Lista.Add(new Amigo { id = 1, nombres = "Carlos Bryan Hinostroza Araujo", correo = "Bryan@gmail.com", provincia = Provincia.Lima });
            Lista.Add(new Amigo { id = 2, nombres = "Cristian Marcelino Hinostroza Araujo", correo = "Cristian@gmail.com", provincia = Provincia.Huaraz });
            Lista.Add(new Amigo { id = 3, nombres = "Karen Milagros Hinostroza Araujo", correo = "Karen@gmail.com", provincia = Provincia.Ves });
        }

        public Amigo GetAmigo(int id)
        {
            return Lista.FirstOrDefault(x => x.id == id);
        }

        public List<Amigo> Listar()
        {
            return Lista;
        }

        public Amigo Nuevo(Amigo amigo)
        {
            /*El max retorna el valor mayor en este caso el id de tipo in y le sumamos + 1 que seria
             el id del nuevo registro*/
            amigo.id = Lista.Max(a=>a.id) + 1;
            Lista.Add(amigo);
            return amigo;
        }
    }
}
