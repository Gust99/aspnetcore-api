using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Entities;

namespace TwoAres.Services
{
    public interface IArtistaService
    {
        Task<IEnumerable<Artista>> GetAllArtistas();
        Task<Artista> GetArtistaById(int Id);
        Task<Artista> GetArtistaByID(int Id);
        Task<Artista> CreateArtista(Artista artista);
        Task UpdateArtista(Artista artistaOld, Artista artistaNew);
        Task DeleteArtista(Artista artista);
    }
}
