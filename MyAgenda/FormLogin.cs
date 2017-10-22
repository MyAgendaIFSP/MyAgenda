using MyAgenda.Controladores.Geral;
using MyAgenda.Seguranca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*Criptografia c = new Criptografia();
            string pass, salt;
            salt = c.GeraSalt();
            pass = c.GetHashSenha("123456", salt);*/

            _autenticarUsuario();
            
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir tela de cadastro como um diálogo
        }

        private void _autenticarUsuario()
        {
            _comecaCarregar();

            //Validar entradas do usuário
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                _mostraErro("Digite um nome de usuário.");
                txtUsuario.Focus();
                _paraCarregar();
                return;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                _mostraErro("Digite sua senha cadastrada.");
                txtSenha.Focus();
                _paraCarregar();
                return;
            }

            UsuarioController usuarioC = UsuarioController.GetInstance();
            bool auth = usuarioC.Autentica(txtUsuario.Text, txtSenha.Text);

            _paraCarregar();

            if (auth)
            {
                //abrir próximo form
                FormMatrizTempo f = new FormMatrizTempo(usuarioC);
                f.Show();
                this.Close();
            }
            else
            {
                _mostraErro("Usuário não autenticado. Verifique suas informações e tente novamente.");
            }
        }

        private void _mostraErro(string msg)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = msg;
            lblStatus.Visible = true;
        }

        private void _mostraSucesso(string msg)
        {
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Text = msg;
            lblStatus.Visible = true;
        }

        private void _comecaCarregar()
        {
            loader1.Active = true;
            _desabilitaTudo();
        }

        private void _paraCarregar()
        {
            loader1.Active = false;
            _habilitaTudo();
        }

        private void _desabilitaTudo()
        {
            foreach(Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        private void _habilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }
    }
}
