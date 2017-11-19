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
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
            this.SuspendLayout();
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
            this.btnAdicionar.Location = new System.Drawing.Point(149, 750);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(16, 173);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(16, 114);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(12, 149);
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
            this.lblTitulo.Location = new System.Drawing.Point(12, 90);
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
            this.lblAdicionarEvento.Location = new System.Drawing.Point(12, 53);
            this.lblAdicionarEvento.Name = "lblAdicionarEvento";
            this.lblAdicionarEvento.Size = new System.Drawing.Size(163, 21);
            this.lblAdicionarEvento.TabIndex = 11;
            this.lblAdicionarEvento.Text = "Adicionar evento";
            // 
            // pnlEventos
            // 
            this.pnlEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEventos.AutoScroll = true;
            this.pnlEventos.Location = new System.Drawing.Point(288, 53);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(527, 731);
            this.pnlEventos.TabIndex = 9;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 208);
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
            this.lblHorarioInicio.Location = new System.Drawing.Point(12, 409);
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
            this.dtpHorarioInicial.Location = new System.Drawing.Point(16, 433);
            this.dtpHorarioInicial.Name = "dtpHorarioInicial";
            this.dtpHorarioInicial.ShowUpDown = true;
            this.dtpHorarioInicial.Size = new System.Drawing.Size(255, 20);
            this.dtpHorarioInicial.TabIndex = 20;
            // 
            // cldDataInicio
            // 
            this.cldDataInicio.Location = new System.Drawing.Point(16, 238);
            this.cldDataInicio.MaxSelectionCount = 1;
            this.cldDataInicio.Name = "cldDataInicio";
            this.cldDataInicio.TabIndex = 21;
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(12, 461);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 22;
            this.lblDataTermino.Text = "Data Término";
            // 
            // cldDataTermino
            // 
            this.cldDataTermino.Location = new System.Drawing.Point(16, 491);
            this.cldDataTermino.MaxSelectionCount = 1;
            this.cldDataTermino.Name = "cldDataTermino";
            this.cldDataTermino.TabIndex = 23;
            // 
            // dtpHorarioTermino
            // 
            this.dtpHorarioTermino.AllowDrop = true;
            this.dtpHorarioTermino.CustomFormat = "";
            this.dtpHorarioTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioTermino.Location = new System.Drawing.Point(16, 686);
            this.dtpHorarioTermino.Name = "dtpHorarioTermino";
            this.dtpHorarioTermino.ShowUpDown = true;
            this.dtpHorarioTermino.Size = new System.Drawing.Size(255, 20);
            this.dtpHorarioTermino.TabIndex = 25;
            // 
            // lblHorarioTermino
            // 
            this.lblHorarioTermino.AutoSize = true;
            this.lblHorarioTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHorarioTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioTermino.Location = new System.Drawing.Point(12, 662);
            this.lblHorarioTermino.Name = "lblHorarioTermino";
            this.lblHorarioTermino.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioTermino.TabIndex = 24;
            this.lblHorarioTermino.Text = "Horário Início";
            // 
            // barraNavegacao1
            // 
            this.barraNavegacao1.BackColor = System.Drawing.Color.LightSlateGray;
            this.barraNavegacao1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraNavegacao1.Location = new System.Drawing.Point(0, 0);
            this.barraNavegacao1.Name = "barraNavegacao1";
            this.barraNavegacao1.Size = new System.Drawing.Size(827, 40);
            this.barraNavegacao1.TabIndex = 0;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 796);
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
            this.Controls.Add(this.barraNavegacao1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.BarraNavegacao barraNavegacao1;
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