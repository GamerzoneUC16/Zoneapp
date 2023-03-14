using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;
using Zoneclass;

namespace Zoneclass
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime ArquivadoEm { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public string Hashcode { get; set; }

        public Pedido()
        {
            Usuario = new Usuario();
            Cliente = new Cliente();
            Itens = new List<ItemPedido>();
        }

        public Pedido(Cliente cliente, Usuario usuario)
        {
            Data = new DateTime();
            Status = "A";
            Desconto = 0;
            Cliente = cliente;
            Usuario = usuario;
        }

        public Pedido(int id, string hashcode, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivadoEm, List<ItemPedido> itens = null)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
            Hashcode = hashcode;
            ArquivadoEm = arquivadoEm;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id)" +
                              "values(default, default, 0, @client, @user);";

            cmd.Parameters.Add("@client", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@user", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Random rand = new Random();
            string hash = "P" + Id + rand.Next(10001, 99999);
            Hashcode = hash;
            cmd.CommandText = "update pedidos set hashcode = '" + hash + "' where id =" + Id;
            cmd.ExecuteNonQuery();
        }
        public static List<Pedido> Listar(int a = 0)
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado_em is null order by id desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetString(7),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    Usuario.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    ItemPedido.Listar(dr.GetInt32(0))
                    )
                    );
            }
            return list;
        }
        public static List<Pedido> Arquivados(int a = 0)
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado_em is not null order by arquivado_em desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetString(7),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    Usuario.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    ItemPedido.Listar(dr.GetInt32(0))

                    )
                    );
            }
            return list;
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where id=" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido.Id = dr.GetInt32(0);
                pedido.Hashcode = dr.GetString(7);
                pedido.Data = dr.GetDateTime(1);
                pedido.Status = dr.GetString(2);
                pedido.Desconto = dr.GetDouble(3);
                pedido.Cliente = Cliente.ObterPorId(dr.GetInt32(4));
                pedido.Usuario = Usuario.ObterPorId(dr.GetInt32(5));
                pedido.ArquivadoEm = dr.GetDateTime(6);
                pedido.Itens = ItemPedido.Listar(dr.GetInt32(0));
            }

            return pedido;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set status = @status, desconto = @desconto where id = @id; ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
        }

        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado_em = now() where id =  " + Id;
            cmd.ExecuteNonQuery();
        }
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado_em = null where id =  " + id;
            cmd.ExecuteNonQuery();
        }
        //public double ObterTotal() 
        //{

        //}
    }
}