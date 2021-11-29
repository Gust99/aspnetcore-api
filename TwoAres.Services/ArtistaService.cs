using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core;
using TwoAres.Core.Entities;

namespace TwoAres.Services
{
    public class ArtistaService : IArtistaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArtistaService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Artista> GetArtistaByID(int Id)
        {
            return await this._unitOfWork.Artistas.GetByIdArtista(Id);
            //throw new NotImplementedException();
        }
        public async Task<Artista> CreateArtista(Artista artistaNew)
        {
            await this._unitOfWork.Artistas.Add(artistaNew);
            await this._unitOfWork.Commit();
            return artistaNew;
            //throw new NotImplementedException();
        }

        public async Task DeleteArtista(Artista artistaOld)
        {
            this._unitOfWork.Artistas.Remove(artistaOld);
            await this._unitOfWork.Commit();
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<Artista>> GetAllArtistas()
        {
            return await _unitOfWork.Artistas.GetAllArtistas();
            //throw new NotImplementedException();
        }

        public Task<Artista> GetArtistaById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtista(Artista artistaOld, Artista artistaNew)
        {
            throw new NotImplementedException();
        }
    }
}
