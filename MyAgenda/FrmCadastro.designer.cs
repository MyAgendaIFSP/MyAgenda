namespace MyAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtGetNome = new System.Windows.Forms.TextBox();
            this.lblSobreNome = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 72);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 21);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome*";
            // 
            // txtGetNome
            // 
            this.txtGetNome.Location = new System.Drawing.Point(24, 98);
            this.txtGetNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtGetNome.MaxLength = 20;
            this.txtGetNome.Name = "txtGetNome";
            this.txtGetNome.Size = new System.Drawing.Size(516, 27);
            this.txtGetNome.TabIndex = 1;
            this.txtGetNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetNome_KeyPress);
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNome.Location = new System.Drawing.Point(18, 139);
            this.lblSobreNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(105, 21);
            this.lblSobreNome.TabIndex = 8;
            this.lblSobreNome.Text = "Sobrenome*";
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.BackColor = System.Drawing.Color.White;
            this.btnContinuarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnContinuarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinuarCadastro.Location = new System.Drawing.Point(413, 286);
            this.btnContinuarCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(125, 37);
            this.btnContinuarCadastro.TabIndex = 5;
            this.btnContinuarCadastro.Text = "Continuar";
            this.btnContinuarCadastro.UseVisualStyleBackColor = false;
            this.btnContinuarCadastro.Click += new System.EventHandler(this.btnContinuarCadastro_Click);
            this.btnContinuarCadastro.MouseEnter += new System.EventHandler(this.btnContinuarCadastro_MouseEnter);
            this.btnContinuarCadastro.MouseLeave += new System.EventHandler(this.btnContinuarCadastro_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastrar";
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.White;
            this.btnCancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(22, 286);
            this.btnCancelarCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(125, 37);
            this.btnCancelarCadastro.TabIndex = 8;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            this.btnCancelarCadastro.MouseEnter += new System.EventHandler(this.btnCancelarCadastro_MouseEnter);
            this.btnCancelarCadastro.MouseLeave += new System.EventHandler(this.btnCancelarCadastro_MouseLeave);
            // 
            // pbCadastrar
            // 
            this.pbCadastrar.BackColor = System.Drawing.Color.White;
            this.pbCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCadastrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbCadastrar.Location = new System.Drawing.Point(0, 0);
            this.pbCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.pbCadastrar.Name = "pbCadastrar";
            this.pbCadastrar.Size = new System.Drawing.Size(552, 10);
            this.pbCadastrar.TabIndex = 15;
            // 
            // txtGetSobreNome
            // 
            this.txtGetSobreNome.Location = new System.Drawing.Point(23, 165);
            this.txtGetSobreNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtGetSobreNome.Name = "txtGetSobreNome";
            this.txtGetSobreNome.Size = new System.Drawing.Size(516, 27);
            this.txtGetSobreNome.TabIndex = 2;
            this.txtGetSobreNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetSobreNome_KeyPress);
            // 
            // txtGetConfirmacaoSenha
            // 
            this.txtGetConfirmacaoSenha.Location = new System.Drawing.Point(23, 165);
            this.txtGetConfirmacaoSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtGetConfirmacaoSenha.Name = "txtGetConfirmacaoSenha";
            this.txtGetConfirmacaoSenha.Size = new System.Drawing.Size(516, 27);
            this.txtGetConfirmacaoSenha.TabIndex = 7;
            this.txtGetConfirmacaoSenha.Visible = false;
            // 
            // txtGetSenha
            // 
            this.txtGetSenha.Location = new System.Drawing.Point(24, 98);
            this.txtGetSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtGetSenha.Name = "txtGetSenha";
            this.txtGetSenha.Size = new System.Drawing.Size(516, 27);
            this.txtGetSenha.TabIndex = 6;
            this.txtGetSenha.Visible = false;
            // 
            // txtGetEmail
            // 
            this.txtGetEmail.Location = new System.Drawing.Point(22, 237);
            this.txtGetEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtGetEmail.MaxLength = 255;
            this.txtGetEmail.Name = "txtGetEmail";
            this.txtGetEmail.Size = new System.Drawing.Size(516, 27);
            this.txtGetEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email*";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(20, 72);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lblConfirmaSenha.Location = new System.Drawing.Point(18, 137);
            this.lblConfirmaSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(169, 21);
            this.lblConfirmaSenha.TabIndex = 21;
            this.lblConfirmaSenha.Text = "Confirme sua senha*";
            this.lblConfirmaSenha.Visible = false;
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.BackColor = System.Drawing.Color.White;
            this.btnFinalizarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinalizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(413, 286);
            this.btnFinalizarCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(125, 37);
            this.btnFinalizarCadastro.TabIndex = 9;
            this.btnFinalizarCadastro.Text = "Finalizar";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = false;
            this.btnFinalizarCadastro.Visible = false;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            this.btnFinalizarCadastro.MouseEnter += new System.EventHandler(this.btnFinalizarCadastro_MouseEnter);
            this.btnFinalizarCadastro.MouseLeave += new System.EventHandler(this.btnFinalizarCadastro_MouseLeave);
            // 
            // btnRetornarCadastro
            // 
            this.btnRetornarCadastro.BackColor = System.Drawing.Color.White;
            this.btnRetornarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRetornarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetornarCadastro.Location = new System.Drawing.Point(22, 286);
            this.btnRetornarCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.btnRetornarCadastro.Name = "btnRetornarCadastro";
            this.btnRetornarCadastro.Size = new System.Drawing.Size(125, 37);
            this.btnRetornarCadastro.TabIndex = 23;
            this.btnRetornarCadastro.Text = "Retornar";
            this.btnRetornarCadastro.UseVisualStyleBackColor = false;
            this.btnRetornarCadastro.Visible = false;
            this.btnRetornarCadastro.Click += new System.EventHandler(this.btnRetornarCadastro_Click);
            this.btnRetornarCadastro.MouseEnter += new System.EventHandler(this.btnRetornarCadastro_MouseEnter);
            this.btnRetornarCadastro.MouseLeave += new System.EventHandler(this.btnRetornarCadastro_MouseLeave);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 342);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGetSenha);
            this.Controls.Add(this.txtGetConfirmacaoSenha);
            this.Controls.Add(this.pbCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtGetNome);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.txtGetSobreNome);
            this.Controls.Add(this.txtGetEmail);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.btnRetornarCadastro);
            this.Controls.Add(this.btnContinuarCadastro);
            this.Controls.Add(this.btnCancelarCadastro);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyAgenda | Cadastro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtGetNome;
        private System.Windows.Forms.Label lblSobreNome;
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
    }
}

