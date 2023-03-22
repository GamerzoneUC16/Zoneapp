using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Images
    {
        public int Id { get; set; }
        public string Caminho { get; set; }
        public bool Principal_Img { get; set; }
        public int Produto_Id { get; set; }

        public Images() { }

        public Images(int id, string caminho, bool principal_img, int produto_id)
        {
            Id = id;
            Caminho = caminho;
            Principal_Img = principal_img;
            Produto_Id = produto_id;
        }
        public Images (string caminho, bool principal_img, int produto_id) 
        {
            Caminho = caminho;
            Principal_Img = principal_img;
            Produto_Id = produto_id;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert images (caminho, principal_img, produto_id) " +
               "values ('" + Caminho + "','" + Principal_Img + "','" + Produto_Id + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Images> Listar() 
        {
            List<Images> lista = new List<Images>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from images order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Images(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetBoolean(2),
                    dr.GetInt32(3)
                    ));
            }
            return lista;
        }
        public static Images ObterPoId(int id)
        {
            Images images = new Images();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from images where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                images.Id = dr.GetInt32(0);
                images.Caminho = dr.GetString(1);
                images.Principal_Img = dr.GetBoolean(2);
                images.Produto_Id = dr.GetInt32(3);
            }
            return images;
        }
        public static void Atualizar (Images images)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update images set nome = '" +
                images.Caminho + "', produto_id = '" + images.Produto_Id +
                "' where id = " + images.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from images where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
}