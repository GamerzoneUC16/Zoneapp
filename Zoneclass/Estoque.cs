using System;
using System.Collections.Generic;
using System.Data;
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
        public Estoque () { }
        public Estoque (int id, int quantidade, DateTime data_entrada, DateTime data_saida, string lote, int produto_id) 
        {
            Id = id;
            Quantidade = quantidade;
            Data_Entrada = data_entrada;
            Data_Saida = data_saida;
            Lote = lote;
            Produto_Id = produto_id;
        }
        public Estoque (int quantidade, DateTime data_entrada, DateTime data_saida, string lote, int produto_id)
        {
            Quantidade = quantidade;
            Data_Entrada = data_entrada;
            Data_Saida = data_saida;
            Lote = lote;
            Produto_Id = produto_id;
        }
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert estoque (quantidade, data_entrada, data_saida, lote, produto_id)" +
                "values ('" + Quantidade + "','" + Data_Entrada + "','" + Data_Saida + "','" + Lote + "','" + Produto_Id + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Estoque> Listar() 
        {
            List<Estoque> lista = new List<Estoque>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from estoque order by lote asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new Estoque(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetDateTime(2),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetInt32(5)));
            }
            return lista;
        }
        public static Estoque ObterPorId(int id) 
        {
            Estoque estoque = new Estoque();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from estoque where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque.Id = dr.GetInt32(0);
                estoque.Quantidade = dr.GetInt32(1);
                estoque.Data_Entrada = dr.GetDateTime(2);
                estoque.Data_Saida = dr.GetDateTime(3);
                estoque.Lote = dr.GetString(4);
                estoque.Produto_Id = dr.GetInt32(5);
            }
            return estoque;
        }
        public static void Atualizar (Estoque estoque) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update estoque set id '" +
                estoque.Id + "', lote = '" + estoque.Lote +
                "' where id = " + estoque.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from estoque where id = " + id;
            bool result = cmd.ExecuteNonQuery()==1?true:false;
            return result;
        }

    }


}
