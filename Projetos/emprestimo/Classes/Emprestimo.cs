using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emprestimo.Classes
{
    public class Emprestimo
    {
    public int EmprestimoId { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; } // Data prevista de devolução.
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public int ItemEmprestadoId { get; set; }
    public ItemEmprestado ItemEmprestado { get; set; }
    }
}