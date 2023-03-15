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
    public class Tipos
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Rotulo { get; set; }

        public Tipos() { }
        public Tipos(string _sigla, string _rotulo)
        {
            Sigla = _sigla;
            Rotulo = _rotulo;
        }
        public Tipos(int _id, string _sigla, string _rotulo)
        {
            Id = _id;
            Sigla = _sigla;
            Rotulo = _rotulo;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert tipos (nome, sigla) values ('" + Sigla + "','" + Rotulo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Tipos> Listar()
        {
            List<Tipos> lista = new List<Tipos>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tipos order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Tipos(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }
            return lista;
        }
        public static Tipos ObterPorId(int _id)
        {
            Tipos tipos = new Tipos();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tipos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipos.Id = dr.GetInt32(0);
                tipos.Sigla = dr.GetString(1);
                tipos.Rotulo = dr.GetString(2);
            }

            return tipos;
        }
        public static void Atualizar(Tipos tipos)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = '" +
                tipos.Rotulo + "', sigla = '" + tipos.Sigla +
                 "' where id = " + tipos.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tipos where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Tipos> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Tipos> lista = new List<Tipos>();
            while (dr.Read())
            {
                lista.Add(new Tipos(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)));
            }
            return lista;
        }

    }
}