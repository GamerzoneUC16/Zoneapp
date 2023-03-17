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

        // construtor
        public Images(int id, string caminho, bool principal_img, int produto_id)
        {
            Id = id;
            Caminho = caminho;
            Principal_Img = principal_img;
            Produto_Id = produto_id;
        }

        Images minhaImagem = new Images(1, "caminho/da/imagem.jpg", true, 123);

        Console.WriteLine($"ID da imagem: {minhaImagem.Id}");
        Console.WriteLine($"Caminho da imagem: {minhaImagem.Caminho}");
        Console.WriteLine($"Imagem principal: {minhaImagem.Principal_Img}");
        Console.WriteLine($"ID do produto: {minhaImagem.Produto_Id}");

    }

}
