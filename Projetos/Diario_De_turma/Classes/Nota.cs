using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diario_De_turma.Classes
{
    public class Nota
    {
    public int NotaId { get; set; }
    public double Valor { get; set; }
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }
    public int MateriaId { get; set; }
    public Materia Materia { get; set; }
    }
}