using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_A_Pagar.Classes
{
    public class Conta
    {
    public int ContaId { get; set; }
    public string Descricao { get; set; }
    public DateTime DataVencimento { get; set; }
    public decimal Valor { get; set; }
    public TipoConta Tipo { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    }
    public enum TipoConta
{
    AReceber,
    APagar
}
}