using System;
using System.Collections.Generic;
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
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (cliente_id, numero, tipo) " +
                "values (" + cliente_id + "'" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Telefone> ListarPorCliente(int cliente_id)
        {
            List<Telefone> listaTel = new List<Telefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero, tipo from telefones where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new Telefone(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2)
                        )

                    );
            }
            return listaTel;
        }
    }
}