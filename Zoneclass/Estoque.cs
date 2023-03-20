using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_Entrada { get; set; }
        public DateTime Data_Saida { get; set; }
        public string Lote { get; set; }
        public int Produto_Id { get; set; }
        public Estoque () { }
        public Estoque (int id, int quantidade, DateTime data_entrada, DateTime data_saida, string lote, int produto_id) 
        {
            Id = id;
            Quantidade = quantidade;
            Data_Entrada = data_entrada;
            Data_Saida = data_saida;
            Lote = lote;
            Produto_Id = produto_id;
        }
        public Estoque (int quantidade, DateTime data_entrada, DateTime data_saida, string lote, int produto_id)
        {
            Quantidade = quantidade;
            Data_Entrada = data_entrada;
            Data_Saida = data_saida;
            Lote = lote;
            Produto_Id = produto_id;
        }

    }


}
