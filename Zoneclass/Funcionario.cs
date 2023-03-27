using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public Nivel Nivel { get; set; }

        public Funcionario () { }
            public Funcionario(int id, string nome, string email, string cpf, Nivel Nivel)
            {
                Id = id;
                Nome = nome;
                Email = email;
                Cpf = cpf;
                Nivel = Nivel;
            }
            public Funcionario (string nome, string email, string cpf, Nivel Nivel) 
            {
                Nome = nome;
                Email = email;
                Cpf = cpf;
                Nivel = Nivel;
            }
            public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert funcionario (nome, email, cpf, Nivel_id) " +
                "values ('" + Nome + "','" + Email + "','" + Cpf + "','" + Nivel +"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Funcionario> Listar()
        {
            List<Funcionario> lista = new List<Funcionario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from funcionario order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4))));
            }
            return lista;
        }
        public static Funcionario ObterPorId(int id)
        {
            Funcionario funcionario = new Funcionario();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from funcionario where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario.Id = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Email = dr.GetString(2);
                funcionario.Cpf = dr.GetString(3);
                funcionario.Nivel = Nivel.ObterPorId(dr.GetInt32(4));
            }
            return funcionario;
        }
        public static void Atualizar (Funcionario funcionario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update funcionario set nome = '" +
                funcionario.Nome + "', email = '" + funcionario.Email +
                "' where id = " + funcionario.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from funcionario where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
    
}
