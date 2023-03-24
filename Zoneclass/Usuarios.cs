using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
       
        public Usuario() { }

        public Usuario(int id, string username, string senha, string nivel)
        {
            Id = id;
            Username = username;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string username, string senha, string nivel)
        {
            Username = username;
            Senha = senha;
            Nivel = nivel;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (username, senha, nivel) " +
                "values ('" + Username + "','" + Senha + "','" + Nivel + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by username asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)));
            }
            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Username = dr.GetString(1);
                usuario.Senha = dr.GetString(2);
                usuario.Nivel = dr.GetString(4);
            }
            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set username = '" +
                usuario.Username + "', senha = '" + usuario.Senha +
                "', '"+usuario.Nivel+"' where id = " + usuario.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from usuarios where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Usuario> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where username like '%" + _parte + "%';";
            var dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)));
            }
            return lista;
        }

    }
}
