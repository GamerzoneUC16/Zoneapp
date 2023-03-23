using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoneclass
{
    public class Caracteristicas
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Caracs { get; set; }
        public Produtos Produtos { get; set; }

        public Caracteristicas() { }

        public Caracteristicas(int id, string modelo, string caracs, Produtos produtos)
        {
            Id = id;
            Modelo = modelo;
            Caracs = caracs;
            Produtos = produtos;
        }
        public Caracteristicas(string modelo, string caracs, Produtos produtos)
        {
            Modelo = modelo;
            Caracs = caracs;
            Produtos = produtos;
        }
        public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert caracteristicas (modelo, caracs, produto_id) " +
                    "values ('" + Modelo + "','" + Caracs + "','" + Produtos+ "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        public  List<Caracteristicas> Listar()
            {
                List<Caracteristicas> lista = new List<Caracteristicas>();
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from caracteristicas order by modelo asc";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                lista.Add(new Caracteristicas(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Produtos.ObterPorId(dr.GetInt32(3))));
                }
                return lista;

            }
        public static Caracteristicas ObterPorId(int id)
        {
            Caracteristicas caracteristicas = new Caracteristicas();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from caracteristicas where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                caracteristicas.Id = dr.GetInt32(0);
                caracteristicas.Modelo = dr.GetString(1);
                caracteristicas.Caracs = dr.GetString(2);
                caracteristicas.Produtos = Produtos.ObterPorId(dr.GetInt32(3));
            }
            return caracteristicas;
    
        }
        public static void Atualizar(Caracteristicas caracteristicas)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update caracteristicas set nome = '" +
                    caracteristicas.Modelo + "', caracteristicas = '" + caracteristicas.Caracs +
                    "' where id = " + caracteristicas.Id;
                cmd.ExecuteReader();
            }
        public bool Excluir (int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from caracteristicas where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
    
    
}