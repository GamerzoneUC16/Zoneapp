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
    public class Tipo
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Rotulo { get; set; }

        public Tipo() { }
        public Tipo(string _sigla, string _rotulo)
        {
            Sigla = _sigla;
            Rotulo = _rotulo;
        }
        public Tipo(int _id, string _sigla, string _rotulo)
        {
            Id = _id;
            Sigla = _sigla;
            Rotulo = _rotulo;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert tipos (sigla, rotulo) values ('" + Sigla + "','" + Rotulo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Tipo> Listar()
        {
            List<Tipo> lista = new List<Tipo>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos order by rotulo asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Tipo(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }
            return lista;
        }
        public static Tipo ObterPorId(int _id)
        {
            Tipo Tipo = new Tipo();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Tipo.Id = dr.GetInt32(0);
                Tipo.Sigla = dr.GetString(1);
                Tipo.Rotulo = dr.GetString(2);
            }

            return Tipo;
        }
        public static void Atualizar(Tipo Tipo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tipos set sigla = '" +
                Tipo.Sigla + "', rotulo = '" + Tipo.Rotulo +
                 "' where id = " + Tipo.Id;
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
        public static List<Tipo> BuscarPorRotulo(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos where rotulo like '%" + _parte + "%' order by rotulo;";
            var dr = cmd.ExecuteReader();
            List<Tipo> lista = new List<Tipo>();
            while (dr.Read())
            {
                lista.Add(new Tipo(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)));
            }
            return lista;
        }

    }
}