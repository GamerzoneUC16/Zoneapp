using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Chamados
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Assunto { get; set; }
        public string Status { get; set; }
        public int Cliente_Id { get; set; }
        public int Usuario_Id { get; set; }
        public string Motivo { get; set; }
        public DateTime Data_Final { get; set; }
        public Chamados() { }
        public Chamados (int id, DateTime data, string titulo, string assunto, string status, int cliente_id, int usuario_id, string motivo, DateTime data_final) 
        {
            Id = id;
            Data = data;
            Titulo = titulo;
            Assunto = assunto;
            Status = status;
            Cliente_Id = cliente_id;
            Usuario_Id = usuario_id;
            Motivo = motivo;
            Data_Final = data_final;
        }
        public Chamados (DateTime data, string titulo, string assunto, string status, int cliente_id, int usuario_id, string motivo, DateTime data_final)
        {
            Data = data;
            Titulo = titulo;
            Assunto = assunto;
            Status = status;
            Cliente_Id = cliente_id;
            Usuario_Id= usuario_id;
            Motivo = motivo;
            Data_Final = data_final;
        }
    }
    


}
