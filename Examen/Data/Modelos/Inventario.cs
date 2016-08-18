using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{

   public class Inventario
    {
        [Key]
        public int id { get; set; }

        public int Cantidad { get; set; }

        public int CantMinima { get; set; }

        public int CantMaxima { get; set; }

        public bool Gravado { get; set; }

        public virtual ICollection<Producto> oProductos { get; set; }
    }
}
