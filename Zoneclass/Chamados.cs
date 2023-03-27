using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoneclass
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Motivo { get; set; }
        public string Assunto { get; set; }
        public string Anexo { get; set; }
        public string Status { get; set; }
        public DateTime Data { get ; set; }
        public string Hashcode { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Data_Final { get; set; }

        public Chamado () { }

        public Chamado(int id, string titulo, string motivo, string assunto, string anexo, string status, DateTime data, string hashcode, Cliente cliente, Usuario usuario, DateTime data_Final)
        {
            Id = id;
            Titulo = titulo;
            Motivo = motivo;
            Assunto = assunto;
            Anexo = anexo;
            Status = status;
            Data = data;
            Hashcode = hashcode;
            Cliente = cliente;
            Usuario = usuario;
            Data_Final = data_Final;
        }

        public Chamado(string titulo, string motivo, string assunto, string anexo, string status, DateTime data, string hashcode, Cliente cliente, Usuario usuario, DateTime data_Final)
        {
            Titulo = titulo;
            Motivo = motivo;
            Assunto = assunto;
            Anexo = anexo;
            Status = status;
            Data = data;
            Hashcode = hashcode;
            Cliente = cliente;
            Usuario = usuario;
            Data_Final = data_Final;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert chamados (titulo, motivo, assunto, anexo, status, data, hashcode, cliente, usuario, data_final) " +
                "values ('" + Titulo + "','" + Motivo + "','" + Assunto + "','" + Anexo + "','" + Status + "','" + Data +"','" + Hashcode + "','" + Cliente + "','" + Usuario + "','" + Data_Final + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "selectt @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Random rand = new Random();
            string hash = "GZH" + Id + rand.Next(01, 1000);
            Hashcode = hash;
            cmd.CommandText = "update chamados set hashcode = '" + hash + "' where id =" + Id;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Chamado> Listar()
        {
            List<Chamado> lista = new List<Chamado>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from chamados order by titulo asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Chamado(dr.GetInt32(0),                   
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    new DateTime(2023,03, 27),
                    dr.GetString(7),
                    Cliente.ObterPorId(dr.GetInt32(8)),   
                    Usuario.ObterPorId(dr.GetInt32(9)),
                  new DateTime(20, 03, 27))
                  );
            }
            dr.Close();
            return lista;
        }
        public static Chamado ObterPorId(int id)
        {
            Chamado Chamado = new Chamado();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from chamados where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Chamado.Id = dr.GetInt32(0);
                Chamado.Titulo = dr.GetString(1);
                Chamado.Motivo = dr.GetString(2);
                Chamado.Assunto = dr.GetString(3);
                Chamado.Anexo = dr.GetString(4);
                Chamado.Status = dr.GetString(5);
                Chamado.Data = dr.GetDateTime(6);
                Chamado.Hashcode = dr.GetString(7);
                Chamado.Cliente = Cliente.ObterPorId(dr.GetInt32(8));
                Chamado.Usuario = Usuario.ObterPorId(dr.GetInt32(9));
                Chamado.Data_Final = dr.GetDateTime(10);
            }
            return Chamado;
        }
        public static void Atualizar (Chamado Chamado)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update chamados set titulo = '" +
                Chamado.Titulo + "', assunto = '" + Chamado.Assunto +
                "' where id = " + Chamado.Id;
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
