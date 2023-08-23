using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emprestimo.Classes
{
    public class ItemEmprestado 
    {
    public int ItemEmprestadoId { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; } // Valor monetário do item.
    }
}