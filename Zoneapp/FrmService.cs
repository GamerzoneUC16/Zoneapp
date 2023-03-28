using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoneclass;
namespace Zoneapp
{
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();

            try
            {
                MailMessage mailMessage = new MailMessage("seuemail@gmail.com", txtEmailCliente.Text);

                mailMessage.Subject = $"{txtTitulo.Text}";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $"<p> {txtMensagem.Text} </p>";
                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("kauapereira2412@gmail.com", txtUserSenha.Text);

                smtpClient.EnableSsl = true;
                MessageBox.Show("Seu email foi enviado com sucesso! :)");
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no envio do email :(");
            }

        }
        private void txtIdChamado_TextChanged(object sender, EventArgs e)
        {
            Chamado chamado = Chamado.ObterPorId(int.Parse(txtIdChamado.Text));
            if (chamado.Id > 0) 
            {
                txtTitulo.Text = chamado.Titulo;
                txtMotivo.Text = chamado.Motivo;
                cmbStatus.Text = chamado.Status;
                txtDescricao.Text = chamado.Assunto;
                txtNomeCliente.Text = chamado.Cliente.Nome;
                txtEmailCliente.Text = chamado.Cliente.Email;
                txtEmailUsuario.Text = chamado.Usuario.Email;
                txtUserSenha.Text = chamado.Usuario.Senha;
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage("seuemail@gmail.com", txtEmailCliente.Text);

                mailMessage.Subject = $"{txtTitulo.Text}";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $"<p> {txtMensagem.Text} </p>";
                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("seuemail@gmail.com", txtUserSenha.Text);

                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);

                MessageBox.Show("Seu email foi enviado com sucesso! :)");
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no envio do email :(");
            }
        }


    }
}
