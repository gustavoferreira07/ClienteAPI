using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteService.Business.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nacionalidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
