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
        
        public FrmPagamento() { }

        public FrmPagamento(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        public FrmPagamento(string tipo)
        {
            Tipo = tipo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert frmpagamento (tipo) values ('" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
        }

        public static List<FrmPagamento> Listar() 
        { 
            List<FrmPagamento> lista = new List<FrmPagamento>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from frmpagamento";
            var dr = cmd.ExecuteNonQuery();
            
            while (dr.Read())
            {
                lista.Add(new FrmPagamento(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    )
                 );
            }
            dr.Close();

            return lista;
        }
    }
}
