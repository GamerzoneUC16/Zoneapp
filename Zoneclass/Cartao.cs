using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Cartao
    {
        // propriedades do cartão
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Validade { get; set; }
        public int Cvv { get; set; }
        public string Tipo { get; set; }

        // construtor
        public Cartao(int id, string numero, DateTime validade, int cvv, string tipo)
        {
            Id = id;
            Numero = numero;
            Validade = validade;
            Cvv = cvv;
            Tipo = tipo;
        }

        // método para verificar se o cartão está expirado
        public bool EstaExpirado()
        {
            return Validade < DateTime.Now;

            Cartao meuCartao = new Cartao(1, "1234567890123456", new DateTime(2025, 12, 31), 123, "VISA");

            Console.WriteLine($"ID do cartão: {meuCartao.Id}");
            Console.WriteLine($"Número do cartão: {meuCartao.Numero}");
            Console.WriteLine($"Data de validade: {meuCartao.Validade.ToShortDateString()}");
            Console.WriteLine($"CVV: {meuCartao.Cvv}");
            Console.WriteLine($"Tipo: {meuCartao.Tipo}");

            if (meuCartao.EstaExpirado())
            {
                Console.WriteLine("Cartão expirado.");
            }
            else
            {
                Console.WriteLine("Cartão válido.");
            }
        }
    }
    
}
