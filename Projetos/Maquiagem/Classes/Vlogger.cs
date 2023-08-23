using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maquiagem.Classes
{
    public class Vlogger
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string TipoDeCanal { get; set; }
        public int QuantasCamerasUsa { get; set; } 
    }
}