using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Entities;

namespace TwoAres.Core.Repositories
{
    public interface IArtistaRepository : IRepository<Artista>
    {
        
        Task<IEnumerable<Artista>> GetAllCanciones();
        Task<Artista> GetCancionById(int Id);
        Task<Artista> GetByIdArtista(int Id);
        Task<Cancion> GetAllWithArtistaByIdArtista(int IdArtista);
        Task<IEnumerable<Artista>> GetAllArtistas();
    }
}
