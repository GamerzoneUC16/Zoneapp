using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Carac_Tec
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Caracs { get; set; }
        public int Produto_Id { get; set; }

        public Carac_Tec() { }

        public Carac_Tec(int id, string nome, string caracs, int produto_Id)
        {
            Id = id;
            Nome = nome;
            Caracs = caracs;
            Produto_Id = produto_Id;
        }
        public Carac_Tec(string nome, string caracs, int produto_id)
        {
            Nome = nome;
            Caracs = caracs;
            Produto_Id = produto_id;
        }
    }
    public void Inserir()
    {
        var cmd = Banco.Abrir();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert carac_tec "
    }
}