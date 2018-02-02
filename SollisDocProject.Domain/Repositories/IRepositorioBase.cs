using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SollisDocProject.Domain.Repositories
{
    public class IRepositorioBase
    {
        public interface IRepositoryBase<TEntity> where TEntity : class
        {
            void Add(TEntity obj);
            TEntity GetById(int  id); 
            IEnumerable<TEntity> GetAll();
            IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression); /** Filtro de Pesquisa por ID **/


            void Update(TEntity obj);
            void Remove(TEntity obj);
            void Dispose();
        }
    }
}
