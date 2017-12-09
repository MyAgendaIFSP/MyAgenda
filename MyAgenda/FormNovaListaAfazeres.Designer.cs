namespace MyAgenda
{
    partial class FormNovaListaAfazeres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaListaAfazeres));
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNovaLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovaLista.AutoSize = true;
            this.btnNovaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNovaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLista.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNovaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovaLista.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnNovaLista.Location = new System.Drawing.Point(189, 188);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(122, 34);
            this.btnNovaLista.TabIndex = 21;
            this.btnNovaLista.Text = "Nova Lista";
            this.btnNovaLista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(16, 71);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(295, 27);
            this.txtTitulo.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Título";
            // 
            // lblNovaLista
            // 
            this.lblNovaLista.AutoSize = true;
            this.lblNovaLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblNovaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNovaLista.Location = new System.Drawing.Point(12, 9);
            this.lblNovaLista.Name = "lblNovaLista";
            this.lblNovaLista.Size = new System.Drawing.Size(204, 21);
            this.lblNovaLista.TabIndex = 18;
            this.lblNovaLista.Text = "Criar Lista de Afazeres";
            // 
            // FormNovaListaAfazeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 234);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNovaLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNovaListaAfazeres";
            this.Text = "MyAgenda | Nova Lista de Afazeres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNovaLista;
    }
}