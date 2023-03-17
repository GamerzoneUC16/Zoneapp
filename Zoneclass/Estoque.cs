using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Estoque
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public DateTime data_entrada { get; set; }
        public DateTime data_saida { get; set; }
        public string lote { get; set; }
        public int produto_id { get; set; }
    }

}
