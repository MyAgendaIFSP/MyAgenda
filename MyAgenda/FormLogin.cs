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
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                _mostraErro("Digite sua senha cadastrada.");
                txtSenha.Focus();
            }

            _paraCarregar();

            btnEntrar.Enabled = true;
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
