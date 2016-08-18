using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Modelos;
using Data;
using System.Data.Entity;

namespace BIExamen
{
    public class BICliente
    {
        public async Task<List<Cliente>> GetAll()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return await db.Clientes.ToListAsync();
        }
    }
}
