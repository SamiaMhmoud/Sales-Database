using EntityTask1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTask1.Data
{
    internal class AplicationDBContext : DbContext
    {
        public DbSet<Costumer> costumers {  get; set; }
        public DbSet<Project> Projects {  get; set; }
        public DbSet<Store> Stores {  get; set; }
        public DbSet<Sales> Sales {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Initial Catalog=EF507;Integrated Security=true;trustServerCertificate=true");
        }

    }
}
