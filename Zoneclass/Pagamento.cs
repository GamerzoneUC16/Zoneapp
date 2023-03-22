using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        public int Parcelas { get; set; }
        public int Frmpagamento_Id { get; set; }
        public Pagamento() { }
        public Pagamento (int id, DateTime data, double preco, int parcelas, int frmpagamento_id) 
        {
            Id = id;
            Data = data;
            Preco = preco;
            Parcelas = parcelas;
            Frmpagamento_Id = frmpagamento_id;
        }
        public Pagamento (DateTime data, double preco, int parcelas, int frmpagamento_id)
        {
            Data = data;
            Preco = preco;
            Parcelas = parcelas;
            Frmpagamento_Id=frmpagamento_id;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert pagamento (data, preco, parcelas, frmpagamento_id) " +
                "values ('" + Data + "','" + Preco + "','" + Parcelas + "','" + Frmpagamento_Id + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Pagamento> Listar() 
        {
            List<Pagamento> lista = new List<Pagamento>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from pagamento order by data asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Pagamento(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetDouble(2),
                    dr.GetInt32(3),
                    dr.GetInt32(4)));
            }
            return lista;
        }
        public static Pagamento ObterPorId(int id)
        {
            Pagamento pagamento = new Pagamento();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ConnectionText = "select * from pagamento where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamento.Id = dr.GetInt32(0);
                pagamento.Data = dr.GetDateTime(1);
                pagamento.Preco = dr.GetDouble(2);
                pagamento.Parcelas = dr.GetInt32(3);
                pagamento.Frmpagamento_Id = dr.GetInt32(4);
            }
            return pagamento;
        }
        public static void Atualizar (Pagamento pagamento)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update pagamento set data = '" +
                pagamento.Data + "', preco = '" + pagamento.Data +
                "'where id = " + pagamento.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pagamento where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }

}
