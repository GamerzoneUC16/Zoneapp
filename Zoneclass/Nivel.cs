using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Zoneclass;

namespace Zoneclass
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Rotulo { get; set; }

        // Métodos constutores
        public Nivel() { }
        public Nivel(string _sigla, string _rotulo)
        {
            Sigla = _sigla;
            Rotulo = _rotulo;
        }
        public Nivel(int _id, string _sigla, string _rotulo)
        {
            Id = _id;
            Sigla = _sigla;
            Rotulo = _rotulo;
            
        }
        // Métodos da classe
        public void Inserir()
        {
            // gravar um novo nivel na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert niveis (nome, sigla) values ('" + Sigla + "','" + Rotulo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Nivel> Listar()
        {
            // 0 - Entrega uma lista de todos os niveis  (cria um espaço do tipo lista)
            List<Nivel> lista = new List<Nivel>();
            // Lógica que recupera todos os niveis da tabela
            // 1 - Abrir conexão com o banco de dados
            var cmd = Banco.Abrir();
            // 2 - Definir tipo de comando SQL (text/store procedure)
            cmd.CommandType = System.Data.CommandType.Text;
            // 3 - Atribuir comando SQL
            cmd.CommandText = "select * from niveis order by nome asc";
            // 4 - Executar o comando sql e armazenar o retorno do banco em um objeto MySqlDataReader
            var dr = cmd.ExecuteReader();
            // 5 - Preencher o objeto List com o retorno do banco, se houver
            while (dr.Read()) // enquanto houver próximo registro
            {
                lista.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }
            // retorna a lista preenchida
            return lista;
        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Sigla = dr.GetString(1);
                nivel.Rotulo = dr.GetString(2);
            }

            return nivel;
        }
        public static void Atualizar(Nivel nivel)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = '" +
                nivel.Rotulo + "', sigla = '" + nivel.Sigla +
                 "' where id = " + nivel.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from niveis where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Nivel> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where nome like '%" + _parte + "%' or email like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Nivel> lista = new List<Nivel>();
            while (dr.Read())
            {
                lista.Add(new Nivel(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)));
            }
            return lista;
        }

    }
}