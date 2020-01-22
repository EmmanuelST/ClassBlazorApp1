using ClassBlazorApp1.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassBlazorApp1.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Personas> Personas { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = ClassTestDb; Trusted_Connection = True; ");
        }
    }
}
