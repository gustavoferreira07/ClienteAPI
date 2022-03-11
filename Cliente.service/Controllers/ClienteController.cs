using ClienteService.Business.Interface.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteService.Business.Models;
namespace Cliente.service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public IClienteBusiness _IClienteBusiness;
        public ClienteController(IClienteBusiness clienteBusiness)
        {
            _IClienteBusiness = clienteBusiness;
        }
        [HttpPost("Adicionar")]

        public void Adiciona(ClienteService.Business.Models.Cliente cliente)
        {
            _IClienteBusiness.Add(cliente);
        }
        [HttpDelete("Deletar")]
        public void Deleta(ClienteService.Business.Models.Cliente cliente)
        {
            _IClienteBusiness.Delete(cliente);
        }
        [HttpPut("Editar")]
        public void Altera(ClienteService.Business.Models.Cliente cliente)
        {
            _IClienteBusiness.Update(cliente);
        }
        [HttpGet("ListarTodos")]
        public List<ClienteService.Business.Models.Cliente> ListarTodos()
        {
            return _IClienteBusiness.GetAll();
        }
        [HttpGet("BuscarPorId")]
        public ClienteService.Business.Models.Cliente BuscarPorId(int id)
        {
            return _IClienteBusiness.GetById(id);
        }

    }
}
