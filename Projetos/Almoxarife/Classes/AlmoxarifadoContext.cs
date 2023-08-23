using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Almoxarife.Classes
{
    public class AlmoxarifadoContext : DbContext
    {
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoDistribuido> ProdutosDistribuidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=Almoxarifado;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}