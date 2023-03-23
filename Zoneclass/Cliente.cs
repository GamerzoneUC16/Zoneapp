    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Zoneclass;

namespace Zoneclass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public Cliente() { }

        public Cliente(int id, string nome, string sobrenome, string email, string cpf, bool ativo)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Cpf = cpf;
            Ativo = ativo;
        }

        public Cliente(string nome, string sobrenome, string email, string cpf, bool ativo) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Cpf = cpf;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert cliente (nome, sobrenome, email, cpf, ativo) " +
            "values ('" + Nome + "','" + Sobrenome + "','" + Email + "','" + Cpf + "'," + Ativo + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());            
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from cliente order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetString(3),
                 dr.GetString(4),
                 dr.GetBoolean(5)
                     ));
            }
            return lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from cliente where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Sobrenome = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Cpf = dr.GetString(4);
                cliente.Ativo = dr.GetBoolean(5);
            }
            return cliente;
        }
        public void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update cliente set nome = '" + cliente.Nome + "'," + "sobrenome = '" + cliente.Sobrenome + "', email = '" + cliente.Email + "', cpf = " + cliente.Cpf + ", ativo = " + cliente.Ativo;
            cmd.ExecuteNonQuery();
        }
        public static bool Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update cliente set ativo = 1 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update cliente set ativo = 0 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from cliente where nome like '%" + _parte + "%' order by cpf;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetBoolean(5)
                    ));
            }
            return lista;
        }
    }
}