using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientesApp.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace ClientesApp.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("BDClientes");

        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
