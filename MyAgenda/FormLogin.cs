using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Geral;
using MyAgenda.Seguranca;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormLogin : BaseForm
    {
        private UsuarioController user = UsuarioController.GetInstance();

        public FormLogin()
        {
            InitializeComponent();

            this.Size = new Size(558, 362);
            this.WindowState = FormWindowState.Normal;
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TemBarraNavegacao = false;
            this.StatusLabel = lblStatus;
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            //Validar entradas do usuário
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                this.MostraErro("Digite um nome de usuário.");
                txtUsuario.Focus();
                this.ParaCarregar();
                return;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                this.MostraErro("Digite sua senha cadastrada.");
                txtSenha.Focus();
                this.ParaCarregar();
                return;
            }

            this.ComecaCarregar();
            worker.RunWorkerAsync();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ParaCarregar();

            if (user.IsAutenticado)
            {
                //abrir próximo form
                FormMatrizTempo f = new FormMatrizTempo(user);
                f.Show();
                this.Hide();
            }
            else
            {
                this.MostraErro("Usuário não autenticado. Verifique suas informações e tente novamente.");
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            user.Autentica(txtUsuario.Text, txtSenha.Text);
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir tela de cadastro como um diálogo
        }

        private void _autenticarUsuario()
        {
            this.ComecaCarregar();

            //Validar entradas do usuário
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                this.MostraErro("Digite um nome de usuário.");
                txtUsuario.Focus();
                this.ParaCarregar();
                return;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                this.MostraErro("Digite sua senha cadastrada.");
                txtSenha.Focus();
                this.ParaCarregar();
                return;
            }

            UsuarioController usuarioC = UsuarioController.GetInstance();
            bool auth = usuarioC.Autentica(txtUsuario.Text, txtSenha.Text);

            this.ParaCarregar();

            if (auth)
            {
                //abrir próximo form
                FormMatrizTempo f = new FormMatrizTempo(usuarioC);
                f.Show();
                this.Hide();
            }
            else
            {
                this.MostraErro("Usuário não autenticado. Verifique suas informações e tente novamente.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Loader.Width = this.Width;
        }

    }
}
