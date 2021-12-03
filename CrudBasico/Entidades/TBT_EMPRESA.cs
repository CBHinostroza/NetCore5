using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Entidades
{
    public class TBT_EMPRESA
    {
        [Key]
        public int IDEMPRESA { get; set; }
        public string NOM_EMPRESA { get; set; }
        public string RUC_EMPRESA { get; set; }
        public string DIR_EMPRESA { get; set; }
        public string DES_IMAGE { get; set; }

        [NotMapped]
        public string NOM_ERROR { get; set; }

    }
}
