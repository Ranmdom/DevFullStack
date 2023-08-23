using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarife.Classes
{
    public class ProdutoDistribuido
    {
    public int ProdutoDistribuidoId { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataDistribuicao { get; set; }
    }
}