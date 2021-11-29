using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Repositories;

namespace TwoAres.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICancionRepository Canciones { get; }
        IArtistaRepository Artistas { get; }
        Task<int> Commit();
    }
}
