using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; } 
    public List<EpisodioAssistido> EpisodiosAssistidos { get; set; }
}
    }
