using ClienteService.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteService.Data
{
    public class ClienteContext: DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
