using ClienteService.Business.Interface;
using ClienteService.Business.Interface.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteService.Business.Cliente
{
    public class ClienteBusiness: IClienteBusiness
    {
        protected IClienteRepository _IClienteRepository;
        public ClienteBusiness(IClienteRepository clienteRepository)           
        {
            _IClienteRepository = clienteRepository;
        }

        public void Add(Models.Cliente cliente)
        {
            _IClienteRepository.Add(cliente);
        }

        public void Delete(Models.Cliente cliente)
        {
            _IClienteRepository.Remove(cliente);
        }

        public void Update(Models.Cliente obj)
        {
            _IClienteRepository.Update(obj);
        }
        public List<Models.Cliente> GetAll()
        {
            return _IClienteRepository.GetAll();
        }
        public Models.Cliente GetById(int id)
        {
            return _IClienteRepository.GetById(id);
        }
    }
}
