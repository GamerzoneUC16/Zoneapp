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
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Datacad { get; set; }
        public bool Ativo { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public Cliente() { }
        public Cliente(int id, string nome, string cpf, string email, DateTime datacad, bool ativo, List<Telefone> telefones, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
            Telefones = telefones;
            Enderecos = enderecos;

        }
        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public Cliente(int id)
        {
            Telefones = Telefone.ListarPorCliente(id);
            Enderecos = Endereco.ListarPorCliente(id);
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, ativo) " +
            "values ('" + Nome + "','" + Cpf + "','" + Email + "','" + Datacad + "'," + Ativo + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            foreach (var telefone in Telefones)
            {
                telefone.Inserir(Id);
            }
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetString(3),
                 dr.GetDateTime(4),
                 dr.GetBoolean(5),
                 Telefone.ListarPorCliente(dr.GetInt32(0)),
                 Endereco.ListarPorCliente(dr.GetInt32(0))
                     )
                 );
            }
            return lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Datacad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
            }
            return cliente;
        }
        public void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update clientes set nome = '" + cliente.Nome + "'," + "cpf = '" + cliente.Cpf + "', email = '" + cliente.Email + "', datacad = " + cliente.Datacad + ", ativo = " + cliente.Ativo;
            cmd.ExecuteNonQuery();
        }
        public static bool Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update clientes set ativo = 1 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update clientes set ativo = 0 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' order by cpf;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetBoolean(5),
                Telefone.ListarPorCliente(dr.GetInt32(0)),
                Endereco.ListarPorCliente(dr.GetInt32(0))
            )
 );
            }
            return lista;
        }
    }
}