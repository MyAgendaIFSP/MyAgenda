namespace MyAgenda.Componentes.ListaContatos.Contato
{
    partial class ContatoItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pcbEstado = new System.Windows.Forms.PictureBox();
            this.pcbMensagem = new System.Windows.Forms.PictureBox();
            this.pcbRemoverContato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMensagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoverContato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "<nome>";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(43, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "<email>";
            // 
            // pcbEstado
            // 
            this.pcbEstado.BackgroundImage = global::MyAgenda.Properties.Resources.ic_status_offline;
            this.pcbEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbEstado.Location = new System.Drawing.Point(14, 13);
            this.pcbEstado.Name = "pcbEstado";
            this.pcbEstado.Size = new System.Drawing.Size(20, 20);
            this.pcbEstado.TabIndex = 3;
            this.pcbEstado.TabStop = false;
            // 
            // pcbMensagem
            // 
            this.pcbMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMensagem.BackgroundImage = global::MyAgenda.Properties.Resources.ic_message_black;
            this.pcbMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMensagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMensagem.Location = new System.Drawing.Point(300, 13);
            this.pcbMensagem.Name = "pcbMensagem";
            this.pcbMensagem.Size = new System.Drawing.Size(20, 20);
            this.pcbMensagem.TabIndex = 4;
            this.pcbMensagem.TabStop = false;
            this.pcbMensagem.Click += new System.EventHandler(this.pcbMensagem_Click);
            // 
            // pcbRemoverContato
            // 
            this.pcbRemoverContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbRemoverContato.BackgroundImage = global::MyAgenda.Properties.Resources.ic_delete_black;
            this.pcbRemoverContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbRemoverContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRemoverContato.Location = new System.Drawing.Point(326, 13);
            this.pcbRemoverContato.Name = "pcbRemoverContato";
            this.pcbRemoverContato.Size = new System.Drawing.Size(20, 20);
            this.pcbRemoverContato.TabIndex = 5;
            this.pcbRemoverContato.TabStop = false;
            this.pcbRemoverContato.Click += new System.EventHandler(this.pcbRemoverContato_Click);
            // 
            // ContatoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pcbEstado);
            this.Controls.Add(this.pcbRemoverContato);
            this.Controls.Add(this.pcbMensagem);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContatoItem";
            this.Size = new System.Drawing.Size(360, 45);
            this.MouseEnter += new System.EventHandler(this.ContatoItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContatoItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoverContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pcbEstado;
        private System.Windows.Forms.PictureBox pcbMensagem;
        private System.Windows.Forms.PictureBox pcbRemoverContato;
    }
}
