using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Chamado
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string titulo { get; set; }
        public string assunto { get; set; }
        public int cliente_id { get; set; }
        public int usuario_id { get; set; }
        public string motivo { get; set; }
        public DateTime data_final { get; set; }
    }

}
