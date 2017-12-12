namespace MyAgenda.Componentes.Geral
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            this.btnDispensar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.timerDispensa = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDispensar
            // 
            this.btnDispensar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispensar.BackColor = System.Drawing.Color.SlateGray;
            this.btnDispensar.BackgroundImage = global::MyAgenda.Properties.Resources.ic_clear_white;
            this.btnDispensar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDispensar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispensar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDispensar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDispensar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispensar.Location = new System.Drawing.Point(339, 5);
            this.btnDispensar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDispensar.Name = "btnDispensar";
            this.btnDispensar.Size = new System.Drawing.Size(25, 25);
            this.btnDispensar.TabIndex = 0;
            this.btnDispensar.UseVisualStyleBackColor = false;
            this.btnDispensar.Click += new System.EventHandler(this.btnDispensar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Notificação";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblMensagem.Location = new System.Drawing.Point(12, 44);
            this.lblMensagem.MaximumSize = new System.Drawing.Size(345, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(86, 19);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem";
            // 
            // timerDispensa
            // 
            this.timerDispensa.Interval = 6000;
            this.timerDispensa.Tick += new System.EventHandler(this.timerDispensa_Tick);
            // 
            // Notification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(370, 0);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDispensar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(370, 0);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDispensar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer timerDispensa;
    }
}