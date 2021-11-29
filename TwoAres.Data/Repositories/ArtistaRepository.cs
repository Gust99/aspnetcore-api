using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Entities;
using TwoAres.Core.Repositories;

namespace TwoAres.Data.Repositories
{
    public class ArtistaRepository : Repository<Artista>, IArtistaRepository
    {
        private TwoAresContext TwoAresContext
        {
            get { return _context as TwoAresContext; }
        }
        public ArtistaRepository(TwoAresContext context) : base(context) { }
        public async Task<IEnumerable<Artista>> GetAllArtistas()
        {
            return await TwoAresContext.Artista.ToListAsync();
        }

        public Task<Artista> GetAllWithArtistaByIdArtista(int IdArtista)
        {
            throw new NotImplementedException();
        }

        public async Task<Artista> GetByIdArtista(int Id)
        {
            return await TwoAresContext.Artista.Where(w => w.Id == Id).FirstAsync();
        }

        public Task<IEnumerable<Artista>> GetAllCanciones()
        {
            throw new NotImplementedException();
        }

        public Task<Artista> GetCancionById(int Id)
        {
            throw new NotImplementedException();
        }

        Task<Cancion> IArtistaRepository.GetAllWithArtistaByIdArtista(int IdArtista)
        {
            throw new NotImplementedException();
        }
    }
}
