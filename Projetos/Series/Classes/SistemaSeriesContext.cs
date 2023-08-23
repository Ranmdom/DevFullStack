using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Series.Classes
{
    public class SistemaSeriesContext : DbContext
    {
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Serie> Series { get; set; }
    public DbSet<Episodio> Episodios { get; set; }
    public DbSet<EpisodioAssistido> EpisodiosAssistidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SQL Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=SistemaSeries;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}