namespace MyAgenda.Componentes.ListaContatos.Chat
{
    partial class ChatMensagem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pbxEstado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblMensagem.Location = new System.Drawing.Point(5, 27);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMensagem.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(296, 95);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "<mensagem> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed facilisis" +
    " vestibulum orci placerat varius. Aliquam orci nisl, vehicula id tempus et, blan" +
    "dit sed tortor.";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblData.ForeColor = System.Drawing.Color.Gray;
            this.lblData.Location = new System.Drawing.Point(26, 131);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 16);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "<data>";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblAutor.Location = new System.Drawing.Point(6, 6);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(58, 17);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "<autor>";
            // 
            // pbxEstado
            // 
            this.pbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxEstado.BackgroundImage = global::MyAgenda.Properties.Resources.ic_check_black;
            this.pbxEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEstado.Location = new System.Drawing.Point(9, 132);
            this.pbxEstado.Name = "pbxEstado";
            this.pbxEstado.Size = new System.Drawing.Size(15, 15);
            this.pbxEstado.TabIndex = 2;
            this.pbxEstado.TabStop = false;
            // 
            // ChatMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.pbxEstado);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblMensagem);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(300, 0);
            this.Name = "ChatMensagem";
            this.Size = new System.Drawing.Size(300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pbxEstado;
        private System.Windows.Forms.Label lblAutor;
    }
}
