using System;
using System.Collections.Generic;

namespace TwoAres.Data.Data
{
    public partial class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? IdArtista { get; set; }

        public virtual Artista IdArtistaNavigation { get; set; }
    }
}
