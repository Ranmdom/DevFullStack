using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emprestimo.Classes
{
    public class BodyBuilder
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Peso { get; set; }
        public double QuantosKgPega { get; set; }
        public string Tipo { get; set; }
    }
}