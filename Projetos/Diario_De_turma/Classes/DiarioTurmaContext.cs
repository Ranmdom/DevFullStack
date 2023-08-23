using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Diario_De_turma.Classes
{
    public class DiarioTurmaContext : DbContext
    {
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Nota> Notas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Sql Server
        optionsBuilder.UseSqlServer("Data Source=SEU_SERVIDOR;Initial Catalog=DiarioTurma;User ID=SEU_USUARIO;Password=SUA_SENHA");
    }
    }
}