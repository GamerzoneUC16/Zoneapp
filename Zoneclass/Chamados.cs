using System;
using System.Collections.Generic;
using System.Data;
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
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert chamados (data, titulo, assunto, status, cliente_id, usuario_id, motivo, data_final) " +
                "values ('" + Data + "','" + Titulo + "','" + Assunto + "','" + Status + "','" + Cliente_Id + "','" + Usuario_Id + "','" + Motivo + "','" + Data_final + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "selectt @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Chamados> Listar()
        {
            List<Chamados> lista = new List<Chamados>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from chamados order by titulo asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Chamados(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetInt32(5),
                    dr.GetInt32(6),
                    dr.GetString(7),
                    dr.GetDateTime(8)));
            }
            return lista;
        }
        public static void Atualizar (Chamados chamados)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update chamados set titulo = '" +
                chamados.Titulo + "', assunto = '" + chamados.Assunto +
                "' where id = " + chamados.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir (int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from chamados where id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
    


}
