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
        public string Titulo { get; set; }
        public string Motivo { get; set; }
        public string Assunto { get; set; }
        public string Anexo { get; set; }
        public string Status { get; set; }
        public DateTime Data { get ; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Data_Final { get; set; }
       
        public Chamados(int id, string titulo, string motivo, string assunto, string anexo, string status, DateTime data, Cliente cliente, Usuario usuario, DateTime data_Final)
        {
            Id = id;
            Titulo = titulo;
            Motivo = motivo;
            Assunto = assunto;
            Anexo = anexo;
            Status = status;
            Data = data;
            Cliente = cliente;
            Usuario = usuario;
            Data_Final = data_Final;
        }

        public Chamados(string titulo, string motivo, string assunto, string anexo, string status, DateTime data, Cliente cliente, Usuario usuario, DateTime data_Final)
        {
            Titulo = titulo;
            Motivo = motivo;
            Assunto = assunto;
            Anexo = anexo;
            Status = status;
            Data = data;
            Cliente = cliente;
            Usuario = usuario;
            Data_Final = data_Final;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert chamados (titulo, motivo, assunto, anexo, status, data, cliente, usuario, data_final) " +
                "values ('" + Titulo + "','" + Motivo + "','" + Assunto + "','" + Anexo + "','" + Status + "','" + Data +"','" + Cliente + "','" + Usuario + "','" + Data_Final + "')";
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
        public static Chamados ObterPorId(int id)
        {
            Chamados chamados = new Chamados();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from chamados where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                chamados.Id = dr.GetInt32(0);
                chamados.Data = dr.GetDateTime(1);
                chamados.Titulo = dr.GetString(2);
                chamados.Assunto = dr.GetString(3);
                chamados.Status = dr.GetString(4);
                chamados.Cliente_Id = dr.GetInt32(5);
                chamados.Usuario_Id = dr.GetInt32(6);
                chamados.Motivo = dr.GetString(7);
                chamados.Data_Final = dr.GetDateTime(8);
            }
            return chamados;
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
