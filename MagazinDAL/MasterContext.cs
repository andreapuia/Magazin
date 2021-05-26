using MagazinDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDAL
{
    public class MasterContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }


        public MasterContext()
            : base("defaultConnection")
        {

        }
    }
}
