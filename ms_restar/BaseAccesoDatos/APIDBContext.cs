using PapAPI.Entity.Codificacion;
using PapAPI.Entity.Dominio;
using PapAPI.Entity.Parameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PapAPI.DataAccess
{
    public class APIDBContext : DbContext
    {
        
        public DbSet<Resta>? Resta { get; set; }

        public APIDBContext( DbContextOptions<APIDBContext> options ) : base( options )
        {

        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);
        }


        

    }
}
