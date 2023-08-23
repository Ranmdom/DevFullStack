using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarife.Classes
{
    public class Usuario
    {
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public List<ProdutoDistribuido> ProdutosDistribuidos { get; set; }
    }
}