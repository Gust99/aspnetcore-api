using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Entities;

namespace TwoAres.Services
{
    public interface ICancionService
    {
        Task<Cancion> GetCancionByID(int Id);
        Task<IEnumerable<Cancion>> GetCancionesByIdArtista(int IdArtista);
        Task<Cancion> CreateCancion(Cancion cancionNew);
        Task UpdateCancion(Cancion cancionOld, Cancion cancionNew);
        Task DeleteCancion(Cancion cancionOld);
        Task<IEnumerable<Cancion>> GetAllCanciones();
    }
}
