using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TwoAres.Core.Entities;
using TwoAres.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TwoAres.Data.Repositories
{
    public class CancionRepository : Repository<Cancion>, ICancionRepository
    {
        private TwoAresContext TwoAresContext
        {
            get { return _context as TwoAresContext; }
        }
        public CancionRepository(TwoAresContext context) : base(context) { }
        public async Task<IEnumerable<Cancion>> GetAllCanciones()
        {
            return await TwoAresContext.Cancion.ToListAsync();
        }

        public Task<Cancion> GetAllWithArtistaByIdArtista(int IdArtista)
        {
            throw new NotImplementedException();
        }

        public async Task<Cancion> GetByIdCancion(int Id)
        {
            return await TwoAresContext.Cancion.Where(w => w.Id == Id).FirstAsync();
        }
        
    }
}
