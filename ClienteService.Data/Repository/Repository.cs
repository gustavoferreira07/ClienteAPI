using ClienteService.Business.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteService.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ClienteContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        protected Repository(ClienteContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        void IRepository<TEntity>.Add(TEntity obj)
        {
            _dbSet.Add(obj);
            _context.SaveChanges();
        }

        List<TEntity> IRepository<TEntity>.GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        TEntity IRepository<TEntity>.GetById(int id)
        {
            return _dbSet.Find(id);
        }

        void IRepository<TEntity>.Remove(TEntity obj)
        {
            _dbSet.Remove(obj);
            _context.SaveChanges();
        }

        void IRepository<TEntity>.Update(TEntity obj)
        {

            _dbSet.Update(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
