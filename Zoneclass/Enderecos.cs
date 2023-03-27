using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Enderecos
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
        public Cliente Cliente { get; set; }
        public Enderecos() { }

        public Enderecos(int id, string logradouro, string numero, string bairro, string cidade, string uf, string cep, string complemento, string tipo)
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
        public Enderecos(string logradouro, string numero, string bairro, string cidade, string uf, string cep, string complemento, string tipo)
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

        public Enderecos(int id, string logradouro, string numero, string bairro, string cidade, string uf, string cep, string complemento, string tipo, Cliente cliente)
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
            Cliente = cliente;
        }

        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (logradouro,numero_end,bairro,cidade,uf,cep,complemento,tipo_end,cliente_id) " + "values ('" + Logradouro + "','" + "','" + Numero + "','" + "','" + Bairro + "','" + Cidade + "','" + Uf + "','" + Cep + "','" + Complemento + "','" + Tipo + "','" +cliente_id+"')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Enderecos> ListarPorCliente(int cliente_id)
        {
            List<Enderecos> listaEnd = new List<Enderecos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero_end, tipo_end from enderecos where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEnd.Add(new Enderecos(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8),
                           Cliente.ObterPorId(dr.GetInt32(9))
                        )

                    );
            }
            return listaEnd;
        }
        public static Enderecos ObterPorId(int id)
        {
            Enderecos enderecos = new Enderecos();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from enderecos where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                enderecos.Id = dr.GetInt32(0);
                enderecos.Logradouro = dr.GetString(1);
                enderecos.Numero = dr.GetString(2);
                enderecos.Bairro = dr.GetString(3);
                enderecos.Cidade = dr.GetString(4);
                enderecos.Uf = dr.GetString(5);
                enderecos.Cep = dr.GetString(6);
                enderecos.Complemento = dr.GetString(7);
                enderecos.Tipo = dr.GetString(8);
                enderecos.Cliente = Cliente.ObterPorId(dr.GetInt32(9));
            }
            return enderecos;
        }
        public static void Atualizar (Enderecos enderecos)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update enderecos set logradouro = '" + enderecos.Logradouro + "', numero_end = '" + enderecos.Numero +"', bairro = '"+enderecos.Bairro+"', '"+enderecos.Cidade+"', '"+enderecos.Uf+"', '"+enderecos.Cep+"', '"+enderecos.Complemento+"', '"+enderecos.Tipo+"', "+enderecos.Cliente+" where id = " + enderecos.Id;
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