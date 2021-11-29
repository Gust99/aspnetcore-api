using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Entities;

namespace TwoAres.Core.Repositories
{
    public interface ICancionRepository : IRepository<Cancion>
    {
        Task<IEnumerable<Cancion>> GetAllCanciones();
        Task<Cancion> GetByIdCancion(int Id);
        Task<Cancion> GetAllWithArtistaByIdArtista(int IdArtista);
    }
}
