using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Chat;
using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using System;
using MyAgenda;
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
            else if (txtSenha.Text.Length < 6)
            {
                this.MostraErro("Sua senha deve possuir entre 6 e 16 caracteres.");
                txtSenha.Focus();
                this.ParaCarregar();
                return;
            }

            this.ComecaCarregar();
            worker.RunWorkerAsync();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _avancaTela();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            user.Autentica(txtUsuario.Text, txtSenha.Text, ckbLembrar.Checked);
        }

        private void _avancaTela()
        {
            this.ParaCarregar();

            if (user.IsAutenticado)
            {
                //abrir próximo form
                FormEventos e = new FormEventos(user);
                e.Show();
                this.Hide();

                ChatController chat = ChatController.GetInstance();
                chat.Escuta = true;
            }
            else
            {
                this.MostraErro("Usuário não autenticado. Verifique suas informações e tente novamente.");
            }
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmCadastro.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Loader.Width = this.Width;

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            UsuarioAPI api = UsuarioAPI.GetInstance();
            this.DesabilitaTudo();

            if (!api.VerificaConexao())
            {
                MostraErro("Sem conexão com o servidor.");
                lblStatus.Enabled = true;
                return;
            }

            this.HabilitaTudo();

            Properties.Settings configs = Properties.Settings.Default;

            if (configs.LembrarLogin)
            {
                this.ComecaCarregar();

                user.AbreSessaoLembrada();
                _avancaTela();
            }
        }
    }
}
