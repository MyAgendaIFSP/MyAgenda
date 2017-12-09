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
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.dtpHorarioInicial = new System.Windows.Forms.DateTimePicker();
            this.cldDataInicio = new System.Windows.Forms.MonthCalendar();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.cldDataTermino = new System.Windows.Forms.MonthCalendar();
            this.dtpHorarioTermino = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioTermino = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraNavegacao
            // 
            this.BarraNavegacao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BarraNavegacao.Size = new System.Drawing.Size(1183, 40);
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
            this.btnAdicionar.Location = new System.Drawing.Point(248, 1123);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(203, 55);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(27, 279);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 27);
            this.txtDescricao.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(27, 184);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(422, 27);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(20, 241);
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
            this.lblTitulo.Location = new System.Drawing.Point(20, 145);
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
            this.lblAdicionarEvento.Location = new System.Drawing.Point(20, 86);
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
            this.pnlEventos.Location = new System.Drawing.Point(480, 86);
            this.pnlEventos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(878, 1092);
            this.pnlEventos.TabIndex = 9;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(20, 336);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(96, 21);
            this.lblDataInicio.TabIndex = 17;
            this.lblDataInicio.Text = "Data Início";
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioInicio.Location = new System.Drawing.Point(20, 661);
            this.lblHorarioInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioInicio.TabIndex = 19;
            this.lblHorarioInicio.Text = "Horário Início";
            // 
            // dtpHorarioInicial
            // 
            this.dtpHorarioInicial.AllowDrop = true;
            this.dtpHorarioInicial.CustomFormat = "";
            this.dtpHorarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicial.Location = new System.Drawing.Point(27, 699);
            this.dtpHorarioInicial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpHorarioInicial.Name = "dtpHorarioInicial";
            this.dtpHorarioInicial.ShowUpDown = true;
            this.dtpHorarioInicial.Size = new System.Drawing.Size(422, 27);
            this.dtpHorarioInicial.TabIndex = 20;
            // 
            // cldDataInicio
            // 
            this.cldDataInicio.Location = new System.Drawing.Point(27, 384);
            this.cldDataInicio.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cldDataInicio.MaxSelectionCount = 1;
            this.cldDataInicio.Name = "cldDataInicio";
            this.cldDataInicio.TabIndex = 21;
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(20, 745);
            this.lblDataTermino.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 22;
            this.lblDataTermino.Text = "Data Término";
            // 
            // cldDataTermino
            // 
            this.cldDataTermino.Location = new System.Drawing.Point(27, 793);
            this.cldDataTermino.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cldDataTermino.MaxSelectionCount = 1;
            this.cldDataTermino.Name = "cldDataTermino";
            this.cldDataTermino.TabIndex = 23;
            // 
            // dtpHorarioTermino
            // 
            this.dtpHorarioTermino.AllowDrop = true;
            this.dtpHorarioTermino.CustomFormat = "";
            this.dtpHorarioTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioTermino.Location = new System.Drawing.Point(27, 1108);
            this.dtpHorarioTermino.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpHorarioTermino.Name = "dtpHorarioTermino";
            this.dtpHorarioTermino.ShowUpDown = true;
            this.dtpHorarioTermino.Size = new System.Drawing.Size(422, 27);
            this.dtpHorarioTermino.TabIndex = 25;
            // 
            // lblHorarioTermino
            // 
            this.lblHorarioTermino.AutoSize = true;
            this.lblHorarioTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHorarioTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioTermino.Location = new System.Drawing.Point(20, 1069);
            this.lblHorarioTermino.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorarioTermino.Name = "lblHorarioTermino";
            this.lblHorarioTermino.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioTermino.TabIndex = 24;
            this.lblHorarioTermino.Text = "Horário Início";
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.dtpHorarioTermino);
            this.Controls.Add(this.lblHorarioTermino);
            this.Controls.Add(this.cldDataTermino);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.cldDataInicio);
            this.Controls.Add(this.dtpHorarioInicial);
            this.Controls.Add(this.lblHorarioInicio);
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
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
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
            this.Controls.SetChildIndex(this.lblHorarioInicio, 0);
            this.Controls.SetChildIndex(this.dtpHorarioInicial, 0);
            this.Controls.SetChildIndex(this.cldDataInicio, 0);
            this.Controls.SetChildIndex(this.lblDataTermino, 0);
            this.Controls.SetChildIndex(this.cldDataTermino, 0);
            this.Controls.SetChildIndex(this.lblHorarioTermino, 0);
            this.Controls.SetChildIndex(this.dtpHorarioTermino, 0);
            this.Controls.SetChildIndex(this.BarraNavegacao, 0);
            this.Controls.SetChildIndex(this.Loader, 0);
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
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicial;
        private System.Windows.Forms.MonthCalendar cldDataInicio;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.MonthCalendar cldDataTermino;
        private System.Windows.Forms.DateTimePicker dtpHorarioTermino;
        private System.Windows.Forms.Label lblHorarioTermino;
    }
}