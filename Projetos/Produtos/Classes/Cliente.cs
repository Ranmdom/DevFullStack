using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Classes
{
    public class Cliente
    {
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public List<Venda> Vendas { get; set; }
    }
}