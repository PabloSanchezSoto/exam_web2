using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        public string nombre { get; set; }
        public string marca { get; set; }
        public string familia { get; set; }
        public string casaFabri { get; set; }
        public string Tipo { get; set; }
        public string departamento { get; set; }
        public bool activo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime fechaIngre { get; set; }
        public int unidad { get; set; }
        public double impuesto { get; set; }

        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public virtual Producto Sorteo { get; set; }

    }
}
