using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace emprestimo.Classes
{
    public class SistemaEmprestimosContext : DbContext
    {
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ItemEmprestado> ItensEmprestados { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=SistemaEmprestimos;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}