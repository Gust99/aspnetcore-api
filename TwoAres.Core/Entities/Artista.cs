using System;
using System.Collections.Generic;

namespace TwoAres.Core.Entities
{
    public partial class Artista
    {
        public Artista()
        {
            Cancion = new HashSet<Cancion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cancion> Cancion { get; set; }
    }
}
