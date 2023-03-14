using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoneclass;

namespace Zoneclass
{
    public class Produto
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
        public Produto() { }
        public Produto(int id, string titulo, string descricao, string resumo, double preco, string image, string destaque, double desconto)
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

        public Produto(string titulo, string descricao, string resumo, double preco, string image, string destaque, double desconto)
        {      
            Titulo = titulo;
            Descricao = descricao;
            Resumo = resumo;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        // Métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert produtos (descricao, unidade, codbar, preco, desconto, descontinuado) " +
                "values ('" + Descricao + "','" + Unidade + "','" + CodBar + "'," + Preco + "," + Desconto + ",0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Produto> Listar()
        {

            List<Produto> lista = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos order by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    )
                );
            }

            return lista;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Id = dr.GetInt32(0);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetString(2);
                produto.CodBar = dr.GetString(3);
                produto.Preco = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }

            return produto;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descricao = '" + Descricao + "'," +
                "unidade = '" + Unidade + "', codbar = '" + CodBar + "', preco = " + Preco + ", desconto = " + Desconto + " , descontinuado = " + Descontinuado + " " +
                "where id = " + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descontinuado = 1 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static bool Restaurar(int id) // restaurando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update produtos set descontinuado = 0 where id = " + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static List<Produto> BuscarPorDestricao(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos where descricao like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (dr.Read())
            {
                lista.Add(new Produto(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDouble(4),
                dr.GetDouble(5),
                dr.GetBoolean(6)
                    )
                );
            }
            return lista;
        }
    }
}