using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Classe
{
    public class Emprestimo
    {
    public int EmprestimoId { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucaoPrevista { get; set; }
    public DateTime? DataDevolucaoReal { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public int FilmeId { get; set; }
    public Filme Filme { get; set; }
    }
}