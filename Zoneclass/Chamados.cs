using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Chamados
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Assunto { get; set; }
        public string Status { get; set; }
        public int Cliente_Id { get; set; }
        public int Usuario_Id { get; set; }
        public string Motivo { get; set; }
        public DateTime Data_Final { get; set; }
    }


}
