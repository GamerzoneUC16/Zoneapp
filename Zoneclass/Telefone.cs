using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }

        public Telefone() { }

        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public Telefone(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
        }

        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero_tel,,tipo_tel,cliente_id) " +
                "values ('" + Numero + "', '" + Tipo + "'," + cliente_id +")";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Telefone> ListarPorCliente(int cliente_id)
        {
            List<Telefone> listaTel = new List<Telefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero_tel, tipo_tel from telefones where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new Telefone(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            Cliente.ObterPorId(dr.GetInt32(4))
                        )

                    );
            }
            return listaTel;
        }
        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new Telefone();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from telefone where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                telefone.Id = dr.GetInt32(0);
                telefone.Numero = dr.GetString(1);
                telefone.Tipo = dr.GetString(2);
            }
            return telefone;
        }
        public static void Atualizar (Telefone telefone) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update telefone set numero_tel = '" +
                telefone.Numero + "', tipo_tel = '" + telefone.Tipo +
                "'where id = " + telefone.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir (int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from telefone where id = " + id;
            bool result = cmd.ExecuteNonQuery()==1?true:false;
            return result;
        }
    }
}