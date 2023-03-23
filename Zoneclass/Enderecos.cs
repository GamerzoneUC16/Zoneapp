using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public Endereco() { }

        public Endereco(int id, string logradouro, string numero, string bairro, string cidade, string uf, string cep, string complemento, string tipo)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;                       
            Complemento = complemento;           
            Tipo = tipo;
        }
        public Endereco(string logradouro, string numero, string bairro, string cidade, string uf, string cep, string complemento, string tipo)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;      
            Complemento = complemento;
            Tipo = tipo;
        }
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cliente_id, logradouro, numero, bairro, cidade, uf, cep, complemento, tipo) " +
                "values (" + cliente_id + "'" + Logradouro + "', '" + Numero + "','" + Bairro + "','" + Cidade + "','" + Uf + "','" + Cep + "','" + Complemento + "','" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Endereco> ListarPorCliente(int cliente_id)
        {
            List<Endereco> listaEnd = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero, tipo from enderecos where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEnd.Add(new Endereco(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8)                           
                        )

                    );
            }
            return listaEnd;
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from enderecos where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                endereco.Id = dr.GetInt32(0);
                endereco.Logradouro = dr.GetString(1);
                endereco.Numero = dr.GetString(2);
                endereco.Bairro = dr.GetString(3);
                endereco.Cidade = dr.GetString(4);
                endereco.Uf = dr.GetString(5);
                endereco.Cep = dr.GetString(6);
                endereco.Complemento = dr.GetString(7);
                endereco.Tipo = dr.GetString(8);
            }
            return endereco;
        }
        public static void Atualizar (Endereco endereco)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update enderecos set logradouro = '" +
                endereco.Logradouro + "', cidade = '" + endereco.Cidade +
                "' where id = " + endereco.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from enderecos where id = " + id;
            bool result = cmd.ExecuteNonQuery()==1?true:false;
            return result;
        }
    }
}