using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maquiagem.Classes
{
    public class Cliente
    {
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public List<HorarioMarcado> HorariosMarcados { get; set; }
    }
}