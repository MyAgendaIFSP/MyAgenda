namespace MyAgenda
{
    partial class FormEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventos));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAdicionarEvento = new System.Windows.Forms.Label();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraNavegacao
            // 
            this.BarraNavegacao.Margin = new System.Windows.Forms.Padding(5);
            this.BarraNavegacao.Size = new System.Drawing.Size(838, 40);
            // 
            // Loader
            // 
            this.Loader.Size = new System.Drawing.Size(349, 7);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnAdicionar.Location = new System.Drawing.Point(214, 573);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(136, 37);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.btnAdicionar_MouseEnter);
            this.btnAdicionar.MouseLeave += new System.EventHandler(this.btnAdicionar_MouseLeave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(18, 193);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(332, 27);
            this.txtDescricao.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(18, 122);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(332, 27);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(14, 167);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(14, 96);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Título";
            // 
            // lblAdicionarEvento
            // 
            this.lblAdicionarEvento.AutoSize = true;
            this.lblAdicionarEvento.BackColor = System.Drawing.Color.White;
            this.lblAdicionarEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdicionarEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdicionarEvento.Location = new System.Drawing.Point(14, 59);
            this.lblAdicionarEvento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdicionarEvento.Name = "lblAdicionarEvento";
            this.lblAdicionarEvento.Size = new System.Drawing.Size(143, 19);
            this.lblAdicionarEvento.TabIndex = 11;
            this.lblAdicionarEvento.Text = "Adicionar evento";
            // 
            // pnlEventos
            // 
            this.pnlEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEventos.AutoScroll = true;
            this.pnlEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventos.Location = new System.Drawing.Point(360, 59);
            this.pnlEventos.Margin = new System.Windows.Forms.Padding(5);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(651, 557);
            this.pnlEventos.TabIndex = 9;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(20, 241);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(173, 21);
            this.lblDataInicio.TabIndex = 17;
            this.lblDataInicio.Text = "Data e hora de início";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(18, 265);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(332, 27);
            this.dtpInicio.TabIndex = 26;
            this.dtpInicio.Value = new System.DateTime(2017, 12, 9, 17, 47, 25, 0);
            // 
            // dtpTermino
            // 
            this.dtpTermino.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermino.Location = new System.Drawing.Point(18, 335);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(332, 27);
            this.dtpTermino.TabIndex = 28;
            this.dtpTermino.Value = new System.DateTime(2017, 12, 9, 17, 47, 25, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Data e hora de término";
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 624);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAdicionarEvento);
            this.Controls.Add(this.pnlEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FormEventos";
            this.Text = "MyAgenda | Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEventos_Load);
            this.Controls.SetChildIndex(this.pnlEventos, 0);
            this.Controls.SetChildIndex(this.lblAdicionarEvento, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.lblDataInicio, 0);
            this.Controls.SetChildIndex(this.BarraNavegacao, 0);
            this.Controls.SetChildIndex(this.Loader, 0);
            this.Controls.SetChildIndex(this.dtpInicio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpTermino, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAdicionarEvento;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label label1;
    }
}