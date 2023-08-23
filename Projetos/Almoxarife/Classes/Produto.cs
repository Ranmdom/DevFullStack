using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarife.Classes
{
    public class Produto
    {
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public List<ProdutoDistribuido> ProdutosDistribuidos { get; set; }
    }
}