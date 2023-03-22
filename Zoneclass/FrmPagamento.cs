using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class FrmPagamento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Cartao_Id { get; set; }
        
        public FrmPagamento() { }

        public FrmPagamento(int id, string tipo, int cartao_id)
        {
            Id = id;
            Tipo = tipo;
            Cartao_Id = cartao_id;
        }
        public FrmPagamento(string tipo, int cartao_id) 
        {
            Tipo = tipo;
            Cartao_Id = cartao_id;
        }
    }
}
