using System;
using System.Collections.Generic;
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
            cmd.CommandType = CommandType;
            cmd.CommandText = "insert images (caminho, principal_img, produto_id) " +
               "values ('" + Caminho + "','" + Principal_Img + "','" + Produto_Id + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Images> Listar() 
        {

        }
    }
}