using System;
using System.Collections.Generic;
using System.Data;
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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert frmpagamento (tipo) values ('" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static List<FrmPagamento> Listar() 
        { 
            List<FrmPagamento> lista = new List<FrmPagamento>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from frmpagamento order by tipo asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FrmPagamento(
                    dr.GetInt32(0),
                    dr.GetString(1)));
            }
            return lista;
        }
        public static FrmPagamento ObterPorId (int id)
        {
            FrmPagamento frmpagamento = new FrmPagamento();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from frmpagamento where id " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               frmpagamento.Id = dr.GetInt32(0);
               frmpagamento.Tipo = dr.GetString(1);
            }
            return frmpagamento;
        }
        public static void Atualizar (FrmPagamento frmpagamento)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update frmpagamento set tipo = '" + frmpagamento.Tipo;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from frmpagamento where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
}
