using Org.BouncyCastle.Asn1.Mozilla;
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
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nivel Nivel { get; set; }
       
        public Usuario() { }

        public Usuario(string _nome, string _login, string _senha, Nivel _nivel)
        {
            Nome = _nome;
            Login = _login;
            Senha = _senha; 
            Nivel = _nivel;          
        }
        public Usuario(int _id, string _nome, string _login, string _senha, Nivel _nivel)
        {
            Id = _id;
            Nome = _nome;
            Login = _login;
            Senha = _senha;
            Nivel = _nivel;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (nome, login, senha, nivel_id) " +
                "values ('" + Nome + "','" + Login + "'," + Senha + ",'" + Nivel.Id + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4))));                    
            }
            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Login = dr.GetString(2);
                usuario.Senha = dr.GetString(3);
                usuario.Nivel = Nivel.ObterPorId(dr.GetInt32(4));
            }
            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set nome = '" +
                usuario.Nome + "', login = '" + usuario.Login +
                "' where id = " + usuario.Id;
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
            cmd.CommandText = "select * from niveis where nome like '%" + _parte + "%' or login like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4))));   
            }
            return lista;
        }

    }
}
