using MyAgenda.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormNewPassword : Form
    {
        string email;
        public FormNewPassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if(txtGetNovaSenha.Text == txtGetConfirmacaoNovaSenha.Text)
            {
                AlteradorSenhaAPI alterador = new AlteradorSenhaAPI();
                alterador.AlterarSenha(this.email, txtGetNovaSenha.Text);
                FormLogin formLogin = new FormLogin();
                this.Close();
                formLogin.Show();
            }
            else
            {
                MessageBox.Show("As senhas não coincidem.");
            }
            
        }
    }
}
