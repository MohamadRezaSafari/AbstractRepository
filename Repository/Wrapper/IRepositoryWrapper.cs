using System;
using System.Threading.Tasks;

namespace Core3.Models.Repository
{
    public interface IRepositoryWrapper : IDisposable
    {
        ICityRepository cityRepository { get; }
        void Save();
    }
}
