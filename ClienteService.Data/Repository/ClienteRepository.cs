using ClienteService.Business.Interface;
using ClienteService.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteService.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext context) : base(context)
        {
        }

        void IRepository<Cliente>.Add(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        List<Cliente> IRepository<Cliente>.GetAll()
        {
            return _context.Clientes.ToList();
        }

        Cliente IRepository<Cliente>.GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        void IRepository<Cliente>.Remove(Cliente obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        void IRepository<Cliente>.Update(Cliente obj)
        {
            _context.Update(obj);
        }
    }
}
