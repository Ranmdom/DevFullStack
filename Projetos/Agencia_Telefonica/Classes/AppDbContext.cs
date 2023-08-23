using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Agencia_Telefonica.Classes
{
    public class AppDbContext : DbContext
    {
        public DbSet<Promotor> Promotores{get; set;}
        public DbSet<Escritor> Escritores{get;set;}
        public DbSet<BodyBuilder> BodyBuilders{get;set;}
        public DbSet<Vlogger> Vloggers{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=127.0.0.1:3306;uid=root;pwd=romulovd2001;database=teste");
        }
    }
}