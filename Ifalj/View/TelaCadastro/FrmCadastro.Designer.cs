namespace Ifalj
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtGetNome = new System.Windows.Forms.TextBox();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.btnContinuarCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.pbCadastrar = new System.Windows.Forms.ProgressBar();
            this.txtGetSobreNome = new System.Windows.Forms.TextBox();
            this.txtGetConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txtGetSenha = new System.Windows.Forms.TextBox();
            this.txtGetEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.btnRetornarCadastro = new System.Windows.Forms.Button();
            this.txtGetApelido = new System.Windows.Forms.TextBox();
            this.btnForgottenPw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(88, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 21);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome*";
            // 
            // txtGetNome
            // 
            this.txtGetNome.Location = new System.Drawing.Point(92, 104);
            this.txtGetNome.MaxLength = 20;
            this.txtGetNome.Name = "txtGetNome";
            this.txtGetNome.Size = new System.Drawing.Size(311, 20);
            this.txtGetNome.TabIndex = 1;
            this.txtGetNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetNome_KeyPress);
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNome.Location = new System.Drawing.Point(88, 145);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(105, 21);
            this.lblSobreNome.TabIndex = 8;
            this.lblSobreNome.Text = "Sobrenome*";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(88, 216);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(71, 21);
            this.lblApelido.TabIndex = 10;
            this.lblApelido.Text = "Apelido";
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.BackColor = System.Drawing.Color.White;
            this.btnContinuarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinuarCadastro.Location = new System.Drawing.Point(263, 314);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnContinuarCadastro.TabIndex = 12;
            this.btnContinuarCadastro.Text = "Continuar";
            this.btnContinuarCadastro.UseVisualStyleBackColor = false;
            this.btnContinuarCadastro.Click += new System.EventHandler(this.btnContinuarCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastrar";
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.White;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(166, 314);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastro.TabIndex = 14;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // pbCadastrar
            // 
            this.pbCadastrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbCadastrar.Location = new System.Drawing.Point(193, 33);
            this.pbCadastrar.Name = "pbCadastrar";
            this.pbCadastrar.Size = new System.Drawing.Size(210, 23);
            this.pbCadastrar.TabIndex = 15;
            // 
            // txtGetSobreNome
            // 
            this.txtGetSobreNome.Location = new System.Drawing.Point(92, 169);
            this.txtGetSobreNome.Name = "txtGetSobreNome";
            this.txtGetSobreNome.Size = new System.Drawing.Size(311, 20);
            this.txtGetSobreNome.TabIndex = 2;
            this.txtGetSobreNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetSobreNome_KeyPress);
            // 
            // txtGetConfirmacaoSenha
            // 
            this.txtGetConfirmacaoSenha.Location = new System.Drawing.Point(92, 249);
            this.txtGetConfirmacaoSenha.Name = "txtGetConfirmacaoSenha";
            this.txtGetConfirmacaoSenha.Size = new System.Drawing.Size(311, 20);
            this.txtGetConfirmacaoSenha.TabIndex = 6;
            this.txtGetConfirmacaoSenha.Visible = false;
            // 
            // txtGetSenha
            // 
            this.txtGetSenha.Location = new System.Drawing.Point(92, 169);
            this.txtGetSenha.Name = "txtGetSenha";
            this.txtGetSenha.Size = new System.Drawing.Size(311, 20);
            this.txtGetSenha.TabIndex = 5;
            this.txtGetSenha.Visible = false;
            // 
            // txtGetEmail
            // 
            this.txtGetEmail.Location = new System.Drawing.Point(92, 104);
            this.txtGetEmail.MaxLength = 255;
            this.txtGetEmail.Name = "txtGetEmail";
            this.txtGetEmail.Size = new System.Drawing.Size(311, 20);
            this.txtGetEmail.TabIndex = 4;
            this.txtGetEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(88, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email*";
            this.lblEmail.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(88, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 21);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "Senha*";
            this.lblSenha.Visible = false;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(88, 216);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(169, 21);
            this.lblConfirmaSenha.TabIndex = 21;
            this.lblConfirmaSenha.Text = "Confirme sua senha*";
            this.lblConfirmaSenha.Visible = false;
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.BackColor = System.Drawing.Color.White;
            this.btnFinalizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(263, 314);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarCadastro.TabIndex = 22;
            this.btnFinalizarCadastro.Text = "Finalizar";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = false;
            this.btnFinalizarCadastro.Visible = false;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // btnRetornarCadastro
            // 
            this.btnRetornarCadastro.BackColor = System.Drawing.Color.White;
            this.btnRetornarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetornarCadastro.Location = new System.Drawing.Point(166, 314);
            this.btnRetornarCadastro.Name = "btnRetornarCadastro";
            this.btnRetornarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnRetornarCadastro.TabIndex = 23;
            this.btnRetornarCadastro.Text = "Retornar";
            this.btnRetornarCadastro.UseVisualStyleBackColor = false;
            this.btnRetornarCadastro.Visible = false;
            this.btnRetornarCadastro.Click += new System.EventHandler(this.btnRetornarCadastro_Click);
            // 
            // txtGetApelido
            // 
            this.txtGetApelido.Location = new System.Drawing.Point(92, 249);
            this.txtGetApelido.Name = "txtGetApelido";
            this.txtGetApelido.Size = new System.Drawing.Size(311, 20);
            this.txtGetApelido.TabIndex = 25;
            // 
            // btnForgottenPw
            // 
            this.btnForgottenPw.Location = new System.Drawing.Point(420, 26);
            this.btnForgottenPw.Name = "btnForgottenPw";
            this.btnForgottenPw.Size = new System.Drawing.Size(75, 45);
            this.btnForgottenPw.TabIndex = 26;
            this.btnForgottenPw.Text = "Esqueci minha senha";
            this.btnForgottenPw.UseVisualStyleBackColor = true;
            this.btnForgottenPw.Click += new System.EventHandler(this.btnForgottenPw_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.btnForgottenPw);
            this.Controls.Add(this.btnRetornarCadastro);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGetEmail);
            this.Controls.Add(this.txtGetSenha);
            this.Controls.Add(this.txtGetConfirmacaoSenha);
            this.Controls.Add(this.pbCadastrar);
            this.Controls.Add(this.btnCancelarCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtGetNome);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.txtGetSobreNome);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.btnContinuarCadastro);
            this.Controls.Add(this.txtGetApelido);
            this.KeyPreview = true;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Cadastro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtGetNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Button btnContinuarCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.ProgressBar pbCadastrar;
        private System.Windows.Forms.TextBox txtGetSobreNome;
        private System.Windows.Forms.TextBox txtGetConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtGetSenha;
        private System.Windows.Forms.TextBox txtGetEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        private System.Windows.Forms.Button btnRetornarCadastro;
        private System.Windows.Forms.TextBox txtGetApelido;
        private System.Windows.Forms.Button btnForgottenPw;
    }
}

