using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Usuario
    {
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public List<Emprestimo> Emprestimos { get; set; }
    }
}