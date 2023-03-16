using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Boleto
    {
        // propriedades do boleto
        public int Id { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string CodigoDeBarras { get; set; }
        public int ClienteId { get; set; }
        public int PedidoId { get; set; }

        // construtor
        public Boleto(int id, DateTime vencimento, decimal valor, string codigoDeBarras, int clienteId, int pedidoId)
        {
            Id = id;
            Vencimento = vencimento;
            Valor = valor;
            CodigoDeBarras = codigoDeBarras;
            ClienteId = clienteId;
            PedidoId = pedidoId;
        }

        // método para calcular juros e multa caso o boleto esteja vencido
        public decimal CalcularJurosMulta()
        {
            if (DateTime.Now > Vencimento)
            {
                decimal juros = Valor * 0.10M; // juros de 10%
                decimal multa = Valor * 0.02M; // multa de 2%
                return juros + multa;
            }
            else
            {
                return 0;
            }
            Boleto meuBoleto = new Boleto(1, new DateTime(2023, 3, 31), 100.00M, "12345678901234567890123456789012345678901234", 1, 1);

            Console.WriteLine($"ID do boleto: {meuBoleto.Id}");
            Console.WriteLine($"Valor: R$ {meuBoleto.Valor}");
            Console.WriteLine($"Data de vencimento: {meuBoleto.Vencimento.ToShortDateString()}");
            Console.WriteLine($"Código de barras: {meuBoleto.CodigoDeBarras}");
            Console.WriteLine($"ID do cliente: {meuBoleto.ClienteId}");
            Console.WriteLine($"ID do pedido: {meuBoleto.PedidoId}");

            decimal jurosMulta = meuBoleto.CalcularJurosMulta();
            if (jurosMulta > 0)
            {
                Console.WriteLine($"Juros e multa: R$ {jurosMulta}");
            }
            else
            {
                Console.WriteLine("Boleto em dia.");
            }

        }
    }

}
