using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Emprestimo
    {
    public int EmprestimoId { get; set; }
    public int LivroId { get; set; }
    public Livro Livro { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }
    }
}