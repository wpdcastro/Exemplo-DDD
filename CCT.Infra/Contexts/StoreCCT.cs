using CCT.Domain.UserBC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerce.Infra.Contexts
{
    public class StoreCCT : DbContext
    {
        public StoreCCT() : base(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = CCTBD; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Conquest> Conquests { get; set; }
        public DbSet<Perfil> Perfis { get; set; }

    }
}
