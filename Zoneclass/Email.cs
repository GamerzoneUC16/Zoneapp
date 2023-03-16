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

            Email meuEmail = new Email(1, "meuemail@email.com", 1);

            Console.WriteLine($"ID do email: {meuEmail.Id}");
            Console.WriteLine($"Endereço do email: {meuEmail.Endereco}");
            Console.WriteLine($"ID do cliente: {meuEmail.ClienteId}");
        }
    }

}
