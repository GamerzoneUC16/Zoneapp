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
    public class Pedidos
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public string Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public FrmPagamento FrmPagamento { get; set; } 
        public DateTime Arquivado { get; set; }

        public Pedidos()
        {
            Cliente = new Cliente();
            Itens = new List<ItemPedido>();
        }

        public Pedidos(Cliente cliente)
        {
            Desconto = 0;
            Cliente = cliente;
        }

        public Pedidos(int id, double preco, double desconto, string status, Cliente cliente, List<ItemPedido> itens, FrmPagamento frmPagamento, DateTime arquivado)
        {
            Id = id;
            Preco = preco;
            Desconto = desconto;
            Status = status;
            Cliente = cliente;
            Itens = itens;
            FrmPagamento = frmPagamento;
            Arquivado = arquivado;
        }

        public Pedidos(double preco, double desconto, string status, Cliente cliente, List<ItemPedido> itens, FrmPagamento frmPagamento, DateTime arquivado)
        {
            Preco = preco;
            Desconto = desconto;
            Status = status;
            Cliente = cliente;
            Itens = itens;
            FrmPagamento = frmPagamento;
            Arquivado = arquivado;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (preco, desconto, status, cliente, itens, frmpagamento, arquivado)" + 
                "values (preco, 0, @cliente, @status, @itens, @frmpagamento, @arquivado);";
             
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Random rand = new Random();
            cmd.ExecuteNonQuery();
        }
        public static List<Pedidos> Listar(int a = 0)
        {
            List<Pedidos> list = new List<Pedidos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado is null order by id desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedidos(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    ItemPedido.Listar(dr.GetInt32(5)),
                    FrmPagamento.ObterPorId(dr.GetInt32(6)),
                    dr.GetDateTime(7)));
            }
            return list;
        }
        public static Pedidos ObterPorId(int id)
                {
                    Pedidos pedidos = new Pedidos();
                    var cmd = Banco.Abrir();
                    cmd.CommandText = "select * from pedidos where id=" + id;
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        pedidos.Id = dr.GetInt32(0);
                        pedidos.Preco = dr.GetDouble(1);
                        pedidos.Desconto = dr.GetDouble(2);
                        pedidos.Status = dr.GetString(3);
                        pedidos.Cliente = Cliente.ObterPorId(dr.GetInt32(3));            
                        pedidos.Itens = ItemPedido.Listar(dr.GetInt32(4));
                        pedidos.FrmPagamento = FrmPagamento.ObterPorId(dr.GetInt32(5));
                        pedidos.Arquivado = dr.GetDateTime(6);
                    }

                    return pedidos;
                }
        public static List<Pedidos> Arquivados(int a = 0)
        {
            List<Pedidos> list = new List<Pedidos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado is not null order by arquivado desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedidos(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    ItemPedido.Listar(dr.GetInt32(5)),
                    FrmPagamento.ObterPorId(dr.GetInt32(6)),
                    dr.GetDateTime(7)));
            }
            return list;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set status = @preco, desconto = @desconto where id = @id; ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
        }

        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado = now() where id =  " + Id;
            cmd.ExecuteNonQuery();
        }
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado = null where id =  " + id;
            cmd.ExecuteNonQuery();
        }
    }
}