using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Modelos;
using Data;
using System.Data.Entity;

namespace BI
{
    class BIProductos
    {
        public async Task<List<Producto>> GetAll()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return await db.Productos.ToListAsync();
        }
    }
}
