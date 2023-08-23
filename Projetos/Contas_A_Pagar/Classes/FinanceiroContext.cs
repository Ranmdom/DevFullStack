using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contas_A_Pagar.Classes
{
    public class FinanceiroContext : DbContext
    {
       public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Conta> Contas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server não vou colocar o meu pq é no localhost
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=Financeiro;User ID=SEU_USUARIO;Password=SUA_SENHA");
    } 
    }
}