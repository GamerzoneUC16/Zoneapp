using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Pagamento
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public decimal preco { get; set; }
        public int parcelas { get; set; }
        public int frmpagamento_id { get; set; }
    }

}
