using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Classe
{
    public class LocadoraContext : DbContext
    {
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer(@"SuaStringDeConexaoAqui");
    }
    }
}