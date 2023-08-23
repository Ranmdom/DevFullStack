using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_A_Pagar.Classes
{
    public class Usuario
    {
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public decimal Renda { get; set; }
    public List<Conta> Contas { get; set; }
    }
}