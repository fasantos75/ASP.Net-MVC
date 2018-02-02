
using SollisDocProject.Domain.Interfaces;
using System.Collections.Generic;
using static SollisDocProject.Domain.Repositories.IRepositorioBase;

namespace SollisDocProject.Domain.Services
{
    public class ServiceBase
    {
        public class ServiceBase<TEntity> : System.IDisposable, IServiceBase<TEntity> where TEntity : class
        {

            private readonly IRepositoryBase<TEntity> _repository;

            public ServiceBase(IRepositoryBase<TEntity> repository)
            {
                _repository = repository;
            }

            public void Add(TEntity obj)
            {
                _repository.Add(obj);
            }

            public void Dispose()
            {
                _repository.Dispose();
            }

            public IEnumerable<TEntity> GetAll()
            {
                return _repository.GetAll();
            }

            public TEntity GetById(int Id)
            {
                return _repository.GetById(Id);
            }

            public void Remove(TEntity obj)
            {
                _repository.Remove(obj);
            }

            public void Update(TEntity obj)
            {
                _repository.Update(obj);
            }
        }
    }
}
