using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maquiagem.Classes
{
    public class HorarioMarcado 
    {
    public int HorarioMarcadoId { get; set; }
    public DateTime DataHora { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public int TipoMaquiagemId { get; set; }
    public TipoMaquiagem TipoMaquiagem { get; set; }
    }
}