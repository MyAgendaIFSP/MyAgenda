using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Modelos.Util
{
    public class Validator
    {
        public String nomeTemporario;
        public String sobreNomeTemporario;
        public DateTime dataNascTemporario;
        public String confirmacaoSenha;
        bool emailValido = false;
        bool senhaValida = false;

        public void ValidaEntrada(object sender, KeyPressEventArgs valor)
        {
            if (char.IsNumber(valor.KeyChar))
            {
                valor.Handled = true;
            }

        }

        public void ValidarCampos(object sender, EventArgs e, TextBox txtGetEmail, TextBox txtGetSenha, TextBox txtGetConfirmacaoSenha, TextBox txtGetNome, TextBox txtGetSobreNome, ProgressBar pbCadastrar, Label lblEmail, Label lblSenha, Label lblConfirmaSenha, TextBox txtGetApelido, Button btnFinalizarCadastro, Button btnVoltarCadastro, Label lblSobreNome, Label lblApelido)
        {
            if (String.IsNullOrWhiteSpace(txtGetNome.Text) || String.IsNullOrWhiteSpace(txtGetSobreNome.Text))
            {
                if (String.IsNullOrWhiteSpace(txtGetNome.Text) == true)
                {
                    MessageBox.Show("Campo 'Nome' obrigatório");
                }
                if(String.IsNullOrWhiteSpace(txtGetSobreNome.Text) == true)
                {
                    MessageBox.Show("Campo 'Sobrenome' obrigatório");
                }
            }
            else
            {
                lblSobreNome.Visible = false;
                lblApelido.Visible = false;

                lblEmail.Visible = true;
                lblSenha.Visible = true;
                lblConfirmaSenha.Visible = true;
           

                txtGetEmail.Visible = true;
                txtGetSenha.Visible = true;
                txtGetConfirmacaoSenha.Visible = true;

                txtGetSenha.UseSystemPasswordChar = true;
                txtGetConfirmacaoSenha.UseSystemPasswordChar = true;

                btnVoltarCadastro.Visible = true;
                btnFinalizarCadastro.Visible = true;

                pbCadastrar.Value += 50;

            }
        }

        public bool ValidarCampos(string txtGetEmail, string txtGetSenha, string txtGetConfirmacaoSenha)
        {
            foreach (char element in txtGetEmail)
            {
                if (element == '@')
                {
                    emailValido = true;
                    break;
                }
            }

            if(emailValido == false)
            {
                MessageBox.Show("Email inválido");
            }

            if (txtGetSenha == txtGetConfirmacaoSenha)
            {
                senhaValida = true;
            }
            else
            {
                MessageBox.Show("As senhas não são idênticas");
            }

            if (emailValido == true && senhaValida == true) return true;
            else return false;
        }
    }              
}

