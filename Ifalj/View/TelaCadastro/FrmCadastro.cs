using Ifalj.Controladores;
using Ifalj.Modelos.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ifalj
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
            validator.ValidarCampos(sender, e, txtGetEmail, txtGetSenha, txtGetConfirmacaoSenha, txtGetNome, txtGetSobreNome, pbCadastrar, lblEmail, lblSenha, lblConfirmaSenha, txtGetApelido, btnFinalizarCadastro, btnRetornarCadastro, lblSobreNome, lblApelido);
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
            recarregadorDados.RecarregarDadosPrimeiraTelaCadastro(txtGetEmail, txtGetSenha, txtGetConfirmacaoSenha, lblEmail, lblSenha, lblConfirmaSenha, btnRetornarCadastro, btnFinalizarCadastro,pbCadastrar, lblSobreNome, lblApelido);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtGetNome.Text) &&
                !String.IsNullOrEmpty(txtGetSobreNome.Text))
            { 
                Gravar(txtGetNome.Text, txtGetSobreNome.Text);
            }
        }

        private void Gravar(string Nome, string SobreNome)
        {
           /* try
            {
                DataConnection dataConnection = new DataConnection();
                dataConnection.Gravar(Nome, SobreNome);
                MessageBox.Show("Dados inseridos com sucesso no banco de dados!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex);
            }*/
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if(validator.ValidarCampos(txtGetEmail.Text, txtGetSenha.Text, txtGetConfirmacaoSenha.Text) == true)
            {
                try
                { 
                        DataConnection dataConnection = new DataConnection();
                        dataConnection.Gravar(txtGetNome.Text, txtGetSobreNome.Text, txtGetApelido.Text, txtGetEmail.Text, txtGetSenha.Text);
                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu: " + ex);
                }
            }
        }

        private void btnForgottenPw_Click(object sender, EventArgs e)
        {

        }
    }
}
