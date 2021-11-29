using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoAres.Core
{
    public class Artista
    {
        public Artista()
        {
            Canciones = new Collection<Cancion>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Cancion> Canciones { get; set; }
    }
}
