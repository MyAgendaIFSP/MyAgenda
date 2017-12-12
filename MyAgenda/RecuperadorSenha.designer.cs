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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperadorSenha));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailRecovery = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.txtGetCodigo = new System.Windows.Forms.TextBox();
            this.btnValidarCodigo = new System.Windows.Forms.Button();
            this.lblDigiteCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(138, 20);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(151, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Cadastrado";
            // 
            // txtEmailRecovery
            // 
            this.txtEmailRecovery.Location = new System.Drawing.Point(28, 62);
            this.txtEmailRecovery.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailRecovery.Name = "txtEmailRecovery";
            this.txtEmailRecovery.Size = new System.Drawing.Size(379, 27);
            this.txtEmailRecovery.TabIndex = 1;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.SlateGray;
            this.btnEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarEmail.Location = new System.Drawing.Point(111, 104);
            this.btnEnviarEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(212, 47);
            this.btnEnviarEmail.TabIndex = 5;
            this.btnEnviarEmail.Text = "Enviar Código";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // txtGetCodigo
            // 
            this.txtGetCodigo.Location = new System.Drawing.Point(28, 214);
            this.txtGetCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGetCodigo.Name = "txtGetCodigo";
            this.txtGetCodigo.Size = new System.Drawing.Size(379, 27);
            this.txtGetCodigo.TabIndex = 6;
            // 
            // btnValidarCodigo
            // 
            this.btnValidarCodigo.BackColor = System.Drawing.Color.SlateGray;
            this.btnValidarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnValidarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarCodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnValidarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnValidarCodigo.Location = new System.Drawing.Point(111, 256);
            this.btnValidarCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(212, 47);
            this.btnValidarCodigo.TabIndex = 7;
            this.btnValidarCodigo.Text = "Validar Código";
            this.btnValidarCodigo.UseVisualStyleBackColor = false;
            this.btnValidarCodigo.Click += new System.EventHandler(this.btnValidarCodigo_Click);
            // 
            // lblDigiteCodigo
            // 
            this.lblDigiteCodigo.AutoSize = true;
            this.lblDigiteCodigo.Location = new System.Drawing.Point(109, 188);
            this.lblDigiteCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDigiteCodigo.Name = "lblDigiteCodigo";
            this.lblDigiteCodigo.Size = new System.Drawing.Size(211, 21);
            this.lblDigiteCodigo.TabIndex = 8;
            this.lblDigiteCodigo.Text = "Digite o Código Recebido";
            // 
            // RecuperadorSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 335);
            this.Controls.Add(this.lblDigiteCodigo);
            this.Controls.Add(this.btnValidarCodigo);
            this.Controls.Add(this.txtGetCodigo);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txtEmailRecovery);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RecuperadorSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recuperar senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailRecovery;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.TextBox txtGetCodigo;
        private System.Windows.Forms.Button btnValidarCodigo;
        private System.Windows.Forms.Label lblDigiteCodigo;
    }
}