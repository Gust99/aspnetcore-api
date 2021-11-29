using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core;
using TwoAres.Core.Repositories;
using TwoAres.Data.Repositories;

namespace TwoAres.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TwoAresContext _context;
        private CancionRepository _cancionRepository;
        private ArtistaRepository _artistaRepository;
        //artista

        public UnitOfWork(TwoAresContext context)
        {
            this._context = context;
        }
        public ICancionRepository Canciones => _cancionRepository = _cancionRepository ?? new CancionRepository(_context);

        public IArtistaRepository Artistas => _artistaRepository = _artistaRepository ?? new ArtistaRepository(_context);

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
