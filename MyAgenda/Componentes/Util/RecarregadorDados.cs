using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ifalj.Modelos.Util
{
    class RecarregadorDados
    {
        public void RecarregarDadosPrimeiraTelaCadastro(TextBox txtGetEmail, TextBox txtGetSenha, TextBox txtGetConfirmacaoSenha, Label lblEmail, Label lblSenha, Label lblConfirmaSenha, Button btnRetornarCadastro, Button btnFinalizarCadastro, ProgressBar pbCadastrar, Label lblsobrenome, Label lblDataNasc)
        {
            txtGetSenha.Visible = false;
            txtGetConfirmacaoSenha.Visible = false;
            txtGetEmail.Visible = false;

            lblSenha.Visible = false;
            lblConfirmaSenha.Visible = false;
            lblEmail.Visible = false;

            lblsobrenome.Visible = true;
            lblDataNasc.Visible = true;

            btnFinalizarCadastro.Visible = false;
            btnRetornarCadastro.Visible = false;

            pbCadastrar.Value -= 50;
            
        }
    }
}
