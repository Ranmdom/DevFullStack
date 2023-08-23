using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Maquiagem.Classes
{
    public class EstudioMaquiagemContext: DbContext
    {
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<TipoMaquiagem> TiposMaquiagem { get; set; }
    public DbSet<HorarioMarcado> HorariosMarcados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=EstudioMaquiagem;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}