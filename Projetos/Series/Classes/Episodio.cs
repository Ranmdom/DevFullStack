using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class Episodio
    {
    public int EpisodioId { get; set; }
    public string Titulo { get; set; }
    public int Temporada { get; set; }
    public int Numero { get; set; }  // Número do episódio na temporada
    public int SerieId { get; set; }
    public Serie Serie { get; set; }
    public List<EpisodioAssistido> EpisodiosAssistidos { get; set; }
    }
}