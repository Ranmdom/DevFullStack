using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Produtos.Classes
{
    public class GerenciamentoProdutoContext : DbContext
    {
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Venda> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=GerenciamentoProdutos;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}