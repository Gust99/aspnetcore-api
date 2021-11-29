using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core;
using TwoAres.Core.Entities;

namespace TwoAres.Services
{
    public class CancionService : ICancionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CancionService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Cancion> GetCancionByID(int Id)
        {
            return await this._unitOfWork.Canciones.GetByIdCancion(Id);
            //throw new NotImplementedException();
        }

        public  async Task<IEnumerable<Cancion>> GetCancionesByIdArtista(int IdArtista)
        {
            return await this._unitOfWork.Canciones.GetAllCanciones();
            //throw new NotImplementedException();
        }
        public async Task<Cancion> CreateCancion(Cancion cancionNew)
        {
            await this._unitOfWork.Canciones.Add(cancionNew);
            await this._unitOfWork.Commit();
            return cancionNew;
            //throw new NotImplementedException();
        }

        public async Task DeleteCancion(Cancion cancionOld)
        {
            this._unitOfWork.Canciones.Remove(cancionOld);
            await this._unitOfWork.Commit();
            //throw new NotImplementedException();
        }        

        public Task UpdateCancion(Cancion cancionOld, Cancion cancionNew)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cancion>> GetAllCanciones()
        {
            return await _unitOfWork.Canciones.GetAllCanciones();
            //throw new NotImplementedException();
        }
    }
}
