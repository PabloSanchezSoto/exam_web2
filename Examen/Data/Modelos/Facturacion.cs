using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    class Facturacion
    {
        [Key]
        public int id { get; set; }
        public Cliente Ciente { get; set; }
        public Inventario Inventario { get; set; }
    }
}
