using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Images
    {
        // propriedades das imagens
        public int Id { get; set; }
        public string Caminho { get; set; }
        public bool Principal_Img { get; set; }
        public int Produto_Id { get; set; }
        public Images() { }

        // construtor
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
    }
}