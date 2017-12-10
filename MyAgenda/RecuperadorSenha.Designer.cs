namespace MyAgenda
{
    partial class RecuperadorSenha
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailRecovery = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Cadastrado";
            // 
            // txtEmailRecovery
            // 
            this.txtEmailRecovery.Location = new System.Drawing.Point(28, 56);
            this.txtEmailRecovery.Name = "txtEmailRecovery";
            this.txtEmailRecovery.Size = new System.Drawing.Size(229, 20);
            this.txtEmailRecovery.TabIndex = 1;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.SlateGray;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarEmail.Location = new System.Drawing.Point(97, 101);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(85, 48);
            this.btnEnviarEmail.TabIndex = 5;
            this.btnEnviarEmail.Text = "Recuperar Senha";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // RecuperadorSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 176);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txtEmailRecovery);
            this.Controls.Add(this.lblEmail);
            this.Name = "RecuperadorSenha";
            this.Text = "RecuperadorSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailRecovery;
        private System.Windows.Forms.Button btnEnviarEmail;
    }
}