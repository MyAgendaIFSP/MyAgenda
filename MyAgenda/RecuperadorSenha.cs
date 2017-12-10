using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using MyAgenda.Controladores;
using MyAgenda.Dados;

namespace MyAgenda
{
    public partial class RecuperadorSenha : Form
    {
        RecuperacaoSenhaAPI dataCon = new RecuperacaoSenhaAPI();
        public RecuperadorSenha()
        {
            InitializeComponent();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if(dataCon.VerificarEmail(txtEmailRecovery.Text) == true) { ServicoEmail(txtEmailRecovery.Text); }
            else { MessageBox.Show("Cadastro inexistente para este email, por valor digite um email válido."); }
        }

        public void ServicoEmail(string email)
        {
            try
            {
                MailMessage mensagem = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                mensagem.From = new MailAddress("ifaljservices@outlook.com", "Ifalj Recovery Service");
                mensagem.To.Add(email);
                mensagem.Subject = ("Recuperação de Senha");
                mensagem.Body = ("Sua senha: " + dataCon.GetSenha(txtEmailRecovery.Text));
                mensagem.Priority = MailPriority.High;

                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Host = "smtp.live.com";
                smtp.Credentials = new System.Net.NetworkCredential("ifaljservices@outlook.com", "ifalj-2017");
                smtp.Send(mensagem);
                Cursor.Current = Cursors.WaitCursor;
                MessageBox.Show("Código enviado com sucesso, por favor verifique seu e mail");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar. Verifique o email digitado e tente novamente ou tente novamente mais tarde.");
            }
        }
    }
}
