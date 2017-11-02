namespace MyAgenda
{
    partial class FormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.chat = new MyAgenda.Componentes.ListaContatos.Chat.Chat();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMensagem);
            this.panel1.Controls.Add(this.btnEnviarMensagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 85);
            this.panel1.TabIndex = 0;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMensagem.Location = new System.Drawing.Point(3, 3);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(332, 77);
            this.txtMensagem.TabIndex = 1;
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarMensagem.BackgroundImage = global::MyAgenda.Properties.Resources.ic_send_black;
            this.btnEnviarMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviarMensagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarMensagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEnviarMensagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(340, 3);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(30, 30);
            this.btnEnviarMensagem.TabIndex = 0;
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            this.btnEnviarMensagem.MouseEnter += new System.EventHandler(this.btnEnviarMensagem_MouseEnter);
            this.btnEnviarMensagem.MouseLeave += new System.EventHandler(this.btnEnviarMensagem_MouseLeave);
            // 
            // chat
            // 
            this.chat.AutoScroll = true;
            this.chat.BackColor = System.Drawing.SystemColors.Control;
            this.chat.Dock = System.Windows.Forms.DockStyle.Top;
            this.chat.Location = new System.Drawing.Point(0, 0);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(376, 348);
            this.chat.TabIndex = 1;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 439);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "FormChat";
            this.Text = "Conversa";
            this.Shown += new System.EventHandler(this.FormChat_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.chat, 0);
            this.Controls.SetChildIndex(this.BarraNavegacao, 0);
            this.Controls.SetChildIndex(this.Loader, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private Componentes.ListaContatos.Chat.Chat chat;
    }
}