using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Resumo { get; set; }
        public double Preco { get; set; }
        public string Image { get; set; }
        public string Destaque { get; set; }
        public double Desconto { get; set; }

        //Métodos construtores 
        public Produtos() { }
        public Produtos(int id, string titulo, string descricao, string resumo, double preco, string image, string destaque, double desconto)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Resumo = resumo;
            Preco = preco;
            Image = image;
            Destaque = destaque;
            Desconto = desconto;
        }

        public Produtos(string titulo, string descricao, string resumo, double preco, string image, string destaque, double desconto)
        {      
            Titulo = titulo;
            Descricao = descricao;
            Resumo = resumo;
            Preco = preco;
            Desconto = desconto;
            Image= image;
            Destaque = destaque;
            Desconto = desconto;
        }

        // Métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert Produtos (titulo, descricao, resumo, preco, image, destaque, desconto) " +
                "values ('" + Titulo + "','" + Descricao + "','" + Resumo + "'," + Preco + "," + Image + "," + Destaque + "," + Desconto + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Produtos> Listar()
        {

            List<Produtos> lista = new List<Produtos>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Produtos order by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produtos(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetDouble(7)
                    )
                );
            }

            return lista;
        }
        public static Produtos ObterPorId(int id)
        {
            Produtos Produtos = new Produtos();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Produtos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produtos.Id = dr.GetInt32(0);
                Produtos.Titulo = dr.GetString(1);
                Produtos.Descricao = dr.GetString(2);
                Produtos.Resumo = dr.GetString(3);
                Produtos.Preco = dr.GetDouble(4);
                Produtos.Image = dr.GetString(5);
                Produtos.Destaque = dr.GetString(6);
                Produtos.Desconto = dr.GetDouble(7);
            }

            return Produtos;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Produtos set titulo = '" + Titulo + "'," +
                "descricao = '" + Descricao + "', resumo = '" + Resumo + "', preco = " + Preco + ", image = " + Image + " , destaque = " + Destaque + " " + " , desconto = " + Desconto +
                "where id = " + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Produtos set descontinuado = 1 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static bool Restaurar(int id) // restaurando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Produtos set descontinuado = 0 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static List<Produtos> BuscarPorDestricao(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Produtos where titulo like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Produtos> lista = new List<Produtos>();
            while (dr.Read())
            {
                lista.Add(new Produtos(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDouble(4),
                dr.GetString(5),
                dr.GetString(6),
                dr.GetDouble(7)
                    )
                );
            }
            return lista;
        }
    }
}