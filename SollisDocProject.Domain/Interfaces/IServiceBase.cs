using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollisDocProject.Domain.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        /** INTERFACE AUTOMATIZAR A CRIAÇÃO DE CRUDS **/

        void Add(TEntity obj);
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll(); /** Sem implementação de Filtro de Busca **/

        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
