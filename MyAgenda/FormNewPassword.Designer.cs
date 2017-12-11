namespace MyAgenda
{
    partial class FormNewPassword
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
            this.lblDigiteNovaSenha = new System.Windows.Forms.Label();
            this.txtGetNovaSenha = new System.Windows.Forms.TextBox();
            this.lblConfNovaSenha = new System.Windows.Forms.Label();
            this.txtGetConfirmacaoNovaSenha = new System.Windows.Forms.TextBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigiteNovaSenha
            // 
            this.lblDigiteNovaSenha.AutoSize = true;
            this.lblDigiteNovaSenha.Location = new System.Drawing.Point(41, 33);
            this.lblDigiteNovaSenha.Name = "lblDigiteNovaSenha";
            this.lblDigiteNovaSenha.Size = new System.Drawing.Size(41, 13);
            this.lblDigiteNovaSenha.TabIndex = 0;
            this.lblDigiteNovaSenha.Text = "Senha:";
            // 
            // txtGetNovaSenha
            // 
            this.txtGetNovaSenha.Location = new System.Drawing.Point(44, 49);
            this.txtGetNovaSenha.Name = "txtGetNovaSenha";
            this.txtGetNovaSenha.Size = new System.Drawing.Size(183, 20);
            this.txtGetNovaSenha.TabIndex = 1;
            // 
            // lblConfNovaSenha
            // 
            this.lblConfNovaSenha.AutoSize = true;
            this.lblConfNovaSenha.Location = new System.Drawing.Point(41, 96);
            this.lblConfNovaSenha.Name = "lblConfNovaSenha";
            this.lblConfNovaSenha.Size = new System.Drawing.Size(103, 13);
            this.lblConfNovaSenha.TabIndex = 2;
            this.lblConfNovaSenha.Text = "Confirme sua senha:";
            // 
            // txtGetConfirmacaoNovaSenha
            // 
            this.txtGetConfirmacaoNovaSenha.Location = new System.Drawing.Point(44, 122);
            this.txtGetConfirmacaoNovaSenha.Name = "txtGetConfirmacaoNovaSenha";
            this.txtGetConfirmacaoNovaSenha.Size = new System.Drawing.Size(183, 20);
            this.txtGetConfirmacaoNovaSenha.TabIndex = 3;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.SlateGray;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSenha.Location = new System.Drawing.Point(71, 170);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(128, 23);
            this.btnAlterarSenha.TabIndex = 4;
            this.btnAlterarSenha.Text = "Finalizar";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 217);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txtGetConfirmacaoNovaSenha);
            this.Controls.Add(this.lblConfNovaSenha);
            this.Controls.Add(this.txtGetNovaSenha);
            this.Controls.Add(this.lblDigiteNovaSenha);
            this.Name = "FormNewPassword";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigiteNovaSenha;
        private System.Windows.Forms.TextBox txtGetNovaSenha;
        private System.Windows.Forms.Label lblConfNovaSenha;
        private System.Windows.Forms.TextBox txtGetConfirmacaoNovaSenha;
        private System.Windows.Forms.Button btnAlterarSenha;
    }
}