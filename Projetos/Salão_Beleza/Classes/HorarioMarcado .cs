using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salão_Beleza.Classes
{
    public class HorarioMarcado 
    {
    public int HorarioMarcadoId { get; set; }
    public DateTime DataHora { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public int ServicoId { get; set; }
    public Servico Servico { get; set; }
    }
}