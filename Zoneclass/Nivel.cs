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
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert niveis (nome, sigla) values ('" + Sigla + "','" + Rotulo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Nivel> Listar()
        {
            
            List<Nivel> lista = new List<Nivel>();           
            var cmd = Banco.Abrir();       
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis order by nome asc";           
            var dr = cmd.ExecuteReader();          
            while (dr.Read())
            {
                lista.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }            
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