
using SollisDocProject.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using static SollisDocProject.Domain.Repositories.IRepositorioBase;

namespace SollisDocProject.Infrastructure.Data.Repositories
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected ContextoBanco Db = new ContextoBanco();

        /** Adiciona Obj Genérico **/
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }


        public void Dispose()
        {
            Db.Dispose();
        }

        /** Enumera Lista Genérica **/
        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }


        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return Db.Set<TEntity>().Where(expression).ToList();
        }

        /** Pega por ID Genérico **/
        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }


        /** Remove Obj Genérico **/
        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }


        /** Modifica Obj Genérico **/
        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
