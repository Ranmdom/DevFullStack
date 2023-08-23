using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Livro
    {
    public int LivroId { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool EstaDisponivel { get; set; }
    }
}