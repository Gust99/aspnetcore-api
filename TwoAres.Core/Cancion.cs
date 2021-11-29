using System;
using System.Collections.Generic;
using System.Text;

namespace TwoAres.Core
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdArtista { get; set; }
        public Artista Artista { get; set; }
    }
}
