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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
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
            this.lblDigiteNovaSenha.Location = new System.Drawing.Point(29, 23);
            this.lblDigiteNovaSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDigiteNovaSenha.Name = "lblDigiteNovaSenha";
            this.lblDigiteNovaSenha.Size = new System.Drawing.Size(63, 21);
            this.lblDigiteNovaSenha.TabIndex = 0;
            this.lblDigiteNovaSenha.Text = "Senha:";
            // 
            // txtGetNovaSenha
            // 
            this.txtGetNovaSenha.Location = new System.Drawing.Point(34, 49);
            this.txtGetNovaSenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGetNovaSenha.Name = "txtGetNovaSenha";
            this.txtGetNovaSenha.Size = new System.Drawing.Size(302, 27);
            this.txtGetNovaSenha.TabIndex = 1;
            this.txtGetNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGetNovaSenha.UseSystemPasswordChar = true;
            // 
            // lblConfNovaSenha
            // 
            this.lblConfNovaSenha.AutoSize = true;
            this.lblConfNovaSenha.Location = new System.Drawing.Point(30, 100);
            this.lblConfNovaSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfNovaSenha.Name = "lblConfNovaSenha";
            this.lblConfNovaSenha.Size = new System.Drawing.Size(167, 21);
            this.lblConfNovaSenha.TabIndex = 2;
            this.lblConfNovaSenha.Text = "Confirme sua senha:";
            // 
            // txtGetConfirmacaoNovaSenha
            // 
            this.txtGetConfirmacaoNovaSenha.Location = new System.Drawing.Point(35, 142);
            this.txtGetConfirmacaoNovaSenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGetConfirmacaoNovaSenha.Name = "txtGetConfirmacaoNovaSenha";
            this.txtGetConfirmacaoNovaSenha.Size = new System.Drawing.Size(302, 27);
            this.txtGetConfirmacaoNovaSenha.TabIndex = 3;
            this.txtGetConfirmacaoNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGetConfirmacaoNovaSenha.UseSystemPasswordChar = true;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.SlateGray;
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSenha.Location = new System.Drawing.Point(85, 199);
            this.btnAlterarSenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(192, 45);
            this.btnAlterarSenha.TabIndex = 4;
            this.btnAlterarSenha.Text = "Finalizar";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 282);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txtGetConfirmacaoNovaSenha);
            this.Controls.Add(this.lblConfNovaSenha);
            this.Controls.Add(this.txtGetNovaSenha);
            this.Controls.Add(this.lblDigiteNovaSenha);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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