using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class EpisodioAssistido
    {
    public int EpisodioAssistidoId { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int EpisodioId { get; set; }
    public Episodio Episodio { get; set; }
    public DateTime Data { get; set; }  // Data em que o episódio foi assistido
    }
}