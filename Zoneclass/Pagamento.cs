using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Preco { get; set; }
        public int Parcelas { get; set; }
        public int Frmpagamento_Id { get; set; }
        public Pagamento() { }
        public Pagamento (int id, DateTime data, decimal preco, int parcelas, int frmpagamento_id) 
        {
            Id = id;
            Data = data;
            Preco = preco;
            Parcelas = parcelas;
            Frmpagamento_Id = frmpagamento_id;
        }
        public Pagamento (DateTime data, decimal preco, int parcelas, int frmpagamento_id)
        {
            Data = data;
            Preco = preco;
            Parcelas = parcelas;
            Frmpagamento_Id=frmpagamento_id;
        }
    }

}
