using MyAgenda.Dados;
using MyAgenda.Modelos.Util;
using System;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FrmCadastro : Form
    {
        MensagemInterface msgInterface = new MensagemInterface();
        Validator validator = new Validator();
        RecarregadorDados recarregadorDados = new RecarregadorDados();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            msgInterface.MensagemCancelar();
        }

        private void txtGetNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.ValidaEntrada(sender, e);
        }

        private void txtGetSobreNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.ValidaEntrada(sender, e);
        }

        private void btnContinuarCadastro_Click(object sender, EventArgs e)
        {
            validator.ValidarCampos(sender, e, txtGetEmail, txtGetSenha, txtGetConfirmacaoSenha, txtGetNome, txtGetSobreNome, pbCadastrar, lblEmail, lblSenha, lblConfirmaSenha, btnFinalizarCadastro, btnRetornarCadastro, lblSobreNome);
        }

        private void frmCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
        private void btnRetornarCadastro_Click(object sender, EventArgs e)
        {
            recarregadorDados.RecarregarDadosPrimeiraTelaCadastro(txtGetEmail, txtGetSenha, txtGetConfirmacaoSenha, lblEmail, lblSenha, lblConfirmaSenha, btnRetornarCadastro, btnFinalizarCadastro, pbCadastrar, lblSobreNome);
        }


        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if(validator.ValidarCampos(txtGetEmail.Text, txtGetSenha.Text, txtGetConfirmacaoSenha.Text) == true)
            {
                try
                {
                    CadastroAPI dataConnection = new CadastroAPI();
                    dataConnection.Gravar(txtGetNome.Text, txtGetSobreNome.Text, txtGetEmail.Text, txtGetSenha.Text);
                    pbCadastrar.Value = 100;
                    MessageBox.Show("Cadastro finalizado com sucesso.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao realizar o cadastro, tente novamente.");
                }
            }
        }

        private void btnCancelarCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnCancelarCadastro.ForeColor = System.Drawing.Color.White;
        }

        private void btnCancelarCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarCadastro.ForeColor = System.Drawing.Color.Black;
        }

        private void btnFinalizarCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnFinalizarCadastro.ForeColor = System.Drawing.Color.White;
        }

        private void btnFinalizarCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnFinalizarCadastro.ForeColor = System.Drawing.Color.Black;
        }

        private void btnRetornarCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnRetornarCadastro.ForeColor = System.Drawing.Color.White;
        }

        private void btnRetornarCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnRetornarCadastro.ForeColor = System.Drawing.Color.Black;
        }

        private void btnContinuarCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnContinuarCadastro.ForeColor = System.Drawing.Color.White;
        }

        private void btnContinuarCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnContinuarCadastro.ForeColor = System.Drawing.Color.Black;
        }
    }
}
