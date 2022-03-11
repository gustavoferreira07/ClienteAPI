using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteService.Business.Interface
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        
    }
}
