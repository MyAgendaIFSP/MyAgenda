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
            this.panelEventos = new System.Windows.Forms.Panel();
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.cldDataInicio = new System.Windows.Forms.MonthCalendar();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.cldDataTermino = new System.Windows.Forms.MonthCalendar();
            this.lblHorarioTermino = new System.Windows.Forms.Label();
            this.dtpHorarioTermino = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelEventos
            // 
            this.panelEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEventos.Location = new System.Drawing.Point(288, 53);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(527, 803);
            this.panelEventos.TabIndex = 2;
            // 
            // barraNavegacao1
            // 
            this.barraNavegacao1.BackColor = System.Drawing.Color.LightSlateGray;
            this.barraNavegacao1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraNavegacao1.Location = new System.Drawing.Point(0, 0);
            this.barraNavegacao1.Name = "barraNavegacao1";
            this.barraNavegacao1.Size = new System.Drawing.Size(827, 40);
            this.barraNavegacao1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar evento";
            this.label1.UseWaitCursor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(16, 117);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 93);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(12, 158);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(16, 182);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 223);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(96, 21);
            this.lblDataInicio.TabIndex = 8;
            this.lblDataInicio.Text = "Data Início";
            // 
            // cldDataInicio
            // 
            this.cldDataInicio.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.cldDataInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldDataInicio.Location = new System.Drawing.Point(16, 250);
            this.cldDataInicio.MaxDate = new System.DateTime(2095, 10, 21, 0, 0, 0, 0);
            this.cldDataInicio.MinDate = new System.DateTime(1995, 10, 21, 0, 0, 0, 0);
            this.cldDataInicio.Name = "cldDataInicio";
            this.cldDataInicio.ShowToday = false;
            this.cldDataInicio.ShowWeekNumbers = true;
            this.cldDataInicio.TabIndex = 9;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioInicio.Location = new System.Drawing.Point(12, 424);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioInicio.TabIndex = 10;
            this.lblHorarioInicio.Text = "Horário Início";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(16, 449);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpHorarioInicio.TabIndex = 11;
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(12, 485);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 12;
            this.lblDataTermino.Text = "Data Término";
            // 
            // cldDataTermino
            // 
            this.cldDataTermino.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.cldDataTermino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldDataTermino.Location = new System.Drawing.Point(16, 515);
            this.cldDataTermino.MaxDate = new System.DateTime(2095, 10, 21, 0, 0, 0, 0);
            this.cldDataTermino.MinDate = new System.DateTime(1995, 10, 21, 0, 0, 0, 0);
            this.cldDataTermino.Name = "cldDataTermino";
            this.cldDataTermino.ShowToday = false;
            this.cldDataTermino.ShowWeekNumbers = true;
            this.cldDataTermino.TabIndex = 13;
            // 
            // lblHorarioTermino
            // 
            this.lblHorarioTermino.AutoSize = true;
            this.lblHorarioTermino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioTermino.Location = new System.Drawing.Point(12, 689);
            this.lblHorarioTermino.Name = "lblHorarioTermino";
            this.lblHorarioTermino.Size = new System.Drawing.Size(130, 21);
            this.lblHorarioTermino.TabIndex = 14;
            this.lblHorarioTermino.Text = "Horário Término";
            // 
            // dtpHorarioTermino
            // 
            this.dtpHorarioTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioTermino.Location = new System.Drawing.Point(16, 713);
            this.dtpHorarioTermino.Name = "dtpHorarioTermino";
            this.dtpHorarioTermino.ShowUpDown = true;
            this.dtpHorarioTermino.Size = new System.Drawing.Size(200, 20);
            this.dtpHorarioTermino.TabIndex = 15;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnAdicionar.Location = new System.Drawing.Point(149, 822);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 868);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtpHorarioTermino);
            this.Controls.Add(this.lblHorarioTermino);
            this.Controls.Add(this.cldDataTermino);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.dtpHorarioInicio);
            this.Controls.Add(this.lblHorarioInicio);
            this.Controls.Add(this.cldDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraNavegacao1);
            this.Controls.Add(this.panelEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEventos;
        private Componentes.BarraNavegacao barraNavegacao1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MonthCalendar cldDataInicio;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.MonthCalendar cldDataTermino;
        private System.Windows.Forms.Label lblHorarioTermino;
        private System.Windows.Forms.DateTimePicker dtpHorarioTermino;
        private System.Windows.Forms.Button btnAdicionar;
    }
}