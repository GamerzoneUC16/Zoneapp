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
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public FrmPagamento FrmPagamento { get; set; } 
        public DateTime Arquivado { get; set; }

        public Pedido()
        {
            Cliente = new Cliente();
            Itens = new List<ItemPedido>();
        }

        public Pedido(Cliente cliente)
        {
            Desconto = 0;
            Cliente = cliente;
        }

        public Pedido(int id, double preco, double desconto, Cliente cliente, List<ItemPedido> itens, FrmPagamento frmPagamento, DateTime arquivado)
        {
            Id = id;
            Preco = preco;
            Desconto = desconto;
            Cliente = cliente;
            Itens = itens;
            FrmPagamento = frmPagamento;
            Arquivado = arquivado;
        }

        public Pedido(double preco, double desconto, Cliente cliente, List<ItemPedido> itens, FrmPagamento frmPagamento, DateTime arquivado)
        {
            Preco = preco;
            Desconto = desconto;
            Cliente = cliente;
            Itens = itens;
            FrmPagamento = frmPagamento;
            Arquivado = arquivado;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (preco, desconto, cliente, itens, frmpagamento, arquivado)" + 
                "values (preco, 0, @cliente, @itens, @frmpagamento, arquivado);";
             
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Random rand = new Random();
            cmd.ExecuteNonQuery();
        }
        public static List<Pedido> Listar(int a = 0)
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado is null order by id desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDouble(2),
                    Cliente.ObterPorId(dr.GetInt32(3)),
                    ItemPedido.Listar(dr.GetInt32(4)),
                    FrmPagamento.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6)));
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
                        pedido.Preco = dr.GetDouble(1);
                        pedido.Desconto = dr.GetDouble(2);
                        pedido.Cliente = Cliente.ObterPorId(dr.GetInt32(3));            
                        pedido.Itens = ItemPedido.Listar(dr.GetInt32(4));
                pedido.FrmPagamento = FrmPagamento.ObterPorId(dr.GetInt32(5));
                        pedido.Arquivado = dr.GetDateTime(6);
                    }

                    return pedido;
                }
        public static List<Pedido> Arquivados(int a = 0)
        {
            List<Pedido> list = new List<Pedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where arquivado is not null order by arquivado desc;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDouble(2),
                    Cliente.ObterPorId(dr.GetInt32(3)),
                    ItemPedido.Listar(dr.GetInt32(4)),
                    FrmPagamento.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6)));
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
            cmd.CommandText = "update pedidos set arquivado_em = now() where id =  " + Id;
            cmd.ExecuteNonQuery();
        }
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set arquivado_em = null where id =  " + id;
            cmd.ExecuteNonQuery();
        }
    }
}