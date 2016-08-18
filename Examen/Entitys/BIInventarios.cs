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
    class BIInventarios
    {
        public async Task<List<Inventario>> GetAll()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return await db.Inventarios.ToListAsync();
        }
    }
}
