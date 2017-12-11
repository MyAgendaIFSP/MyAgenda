using System.Windows.Forms;

namespace MyAgenda.Modelos.Util
{
    class RecarregadorDados
    {
        public void RecarregarDadosPrimeiraTelaCadastro(TextBox txtGetEmail, TextBox txtGetSenha, TextBox txtGetConfirmacaoSenha, Label lblEmail, Label lblSenha, Label lblConfirmaSenha, Button btnRetornarCadastro, Button btnFinalizarCadastro, ProgressBar pbCadastrar, Label lblsobrenome)
        {
            txtGetSenha.Visible = false;
            txtGetConfirmacaoSenha.Visible = false;
            txtGetEmail.Visible = true;

            lblSenha.Visible = false;
            lblConfirmaSenha.Visible = false;
            lblEmail.Visible = true;

            lblsobrenome.Visible = true;

            btnFinalizarCadastro.Visible = false;
            btnRetornarCadastro.Visible = false;

            pbCadastrar.Value -= 50;
            
        }
    }
}
