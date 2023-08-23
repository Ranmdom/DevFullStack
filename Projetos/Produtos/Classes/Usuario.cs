using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Classes
{
    public class Usuario
    {
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; } //Só ta em texto puro por não ser divulgado oficialmente caso contrario eu faria uma criotografia
    public List<Venda> Vendas { get; set; }
    }
}