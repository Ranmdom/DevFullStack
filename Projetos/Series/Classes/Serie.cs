using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class Serie
    {
    public int SerieId { get; set; }
    public string Nome { get; set; }
    public List<Episodio> Episodios { get; set; }
    }
}