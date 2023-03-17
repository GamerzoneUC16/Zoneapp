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
    }


}
