using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaNacid { get; set; }
        public string direccion { get; set; }
        public string estadoCivil { get; set; }
        public string sexo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaIngre { get; set; }
        public string tipo { get; set; }

        [Range(0.00, 0.50)]
        public double Descuento { get; set; }

    }
}
