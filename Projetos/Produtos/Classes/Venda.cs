using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Classes
{
    public class Venda
    {
    public int VendaId { get; set; }
    public DateTime DataVenda { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public int Quantidade { get; set; }
    }
}