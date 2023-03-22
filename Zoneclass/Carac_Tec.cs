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

        public Carac_Tec(int id, string nome, string caracs, int produto_id)
        {
            Id = id;
            Nome = nome;
            Caracs = caracs;
            Produto_Id = produto_id;
        }
        public Carac_Tec(string nome, string caracs, int produto_id)
        {
            Nome = nome;
            Caracs = caracs;
            Produto_Id = produto_id;
        }
        public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert carac_tec (nome, caracs, produto_id) " +
                    "values ('" + Nome + "','" + Caracs + "','" + Produto_Id+ "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        public static List<Carac_Tec> Listar()
            {
                List<Carac_Tec> lista = new List<Carac_Tec>();
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from carac_tec order by nome asc";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Carac_Tec(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3)));
                }
                return lista;

            }
        public static Carac_Tec ObterPorId(int id)
        {
            Carac_Tec carac_tec = new Carac_Tec();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from carac_tec where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                carac_tec.Id = dr.GetInt32(0);
                carac_tec.Nome = dr.GetString(1);
                carac_tec.Caracs = dr.GetString(2);
                carac_tec.Produto_Id = dr.GetInt32(3);
            }
            return carac_tec;
    
        }
        public static void Atualizar(Carac_Tec carac_tec)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update carac_tec set nome = '" +
                    carac_tec.Nome + "', caracs = '" + carac_tec.Caracs +
                    "' where id = " + carac_tec.Id;
                cmd.ExecuteReader();
            }
        public bool Excluir (int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from carac_tec where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
    
    
}