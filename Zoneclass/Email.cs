using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Email
    {
        // propriedades do email
        public int Id { get; set; }
        public string Endereco { get; set; }
        public int ClienteId { get; set; }

        // construtor
        public Email(int id, string endereco, int clienteId)
        {
            Id = id;
            Endereco = endereco;
            ClienteId = clienteId;
        }
        public Email(string endereco, int clienteId) 
        {
            Endereco=endereco;
            ClienteId = clienteId;
        }  
    }

}
