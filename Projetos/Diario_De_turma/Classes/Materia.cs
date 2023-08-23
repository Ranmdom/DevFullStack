using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diario_De_turma.Classes
{
    public class Materia
    {
    public int MateriaId { get; set; }
    public string Nome { get; set; }
    public List<Nota> Notas { get; set; }
    }
}