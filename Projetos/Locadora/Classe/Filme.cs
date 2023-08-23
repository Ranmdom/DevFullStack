using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Classe
{
    public class Filme
    {
    public int FilmeId { get; set; }
    public string Titulo { get; set; }
    public int AnoLancamento { get; set; }
    public bool EstaDisponivel { get; set; }
    }
}