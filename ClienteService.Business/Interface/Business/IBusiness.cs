using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteService.Business.Interface.Business
{
    public interface IBusiness<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Update(TEntity obj);
        List<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
