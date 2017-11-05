namespace MyAgenda
{
    partial class FormEditarEvento
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtpHorarioTermino = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioTermino = new System.Windows.Forms.Label();
            this.cldDataTermino = new System.Windows.Forms.MonthCalendar();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.cldDataInicio = new System.Windows.Forms.MonthCalendar();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEditarEvento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnAdicionar.Location = new System.Drawing.Point(149, 609);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 30;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dtpHorarioTermino
            // 
            this.dtpHorarioTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioTermino.Location = new System.Drawing.Point(358, 406);
            this.dtpHorarioTermino.Name = "dtpHorarioTermino";
            this.dtpHorarioTermino.ShowUpDown = true;
            this.dtpHorarioTermino.Size = new System.Drawing.Size(200, 20);
            this.dtpHorarioTermino.TabIndex = 29;
            // 
            // lblHorarioTermino
            // 
            this.lblHorarioTermino.AutoSize = true;
            this.lblHorarioTermino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioTermino.Location = new System.Drawing.Point(354, 381);
            this.lblHorarioTermino.Name = "lblHorarioTermino";
            this.lblHorarioTermino.Size = new System.Drawing.Size(130, 21);
            this.lblHorarioTermino.TabIndex = 28;
            this.lblHorarioTermino.Text = "Horário Término";
            // 
            // cldDataTermino
            // 
            this.cldDataTermino.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.cldDataTermino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldDataTermino.Location = new System.Drawing.Point(358, 207);
            this.cldDataTermino.MaxDate = new System.DateTime(2095, 10, 21, 0, 0, 0, 0);
            this.cldDataTermino.MinDate = new System.DateTime(1995, 10, 21, 0, 0, 0, 0);
            this.cldDataTermino.Name = "cldDataTermino";
            this.cldDataTermino.ShowToday = false;
            this.cldDataTermino.ShowWeekNumbers = true;
            this.cldDataTermino.TabIndex = 27;
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(354, 180);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 26;
            this.lblDataTermino.Text = "Data Término";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(16, 406);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpHorarioInicio.TabIndex = 25;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioInicio.Location = new System.Drawing.Point(12, 381);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioInicio.TabIndex = 24;
            this.lblHorarioInicio.Text = "Horário Início";
            // 
            // cldDataInicio
            // 
            this.cldDataInicio.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.cldDataInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldDataInicio.Location = new System.Drawing.Point(16, 207);
            this.cldDataInicio.MaxDate = new System.DateTime(2095, 10, 21, 0, 0, 0, 0);
            this.cldDataInicio.MinDate = new System.DateTime(1995, 10, 21, 0, 0, 0, 0);
            this.cldDataInicio.Name = "cldDataInicio";
            this.cldDataInicio.ShowToday = false;
            this.cldDataInicio.ShowWeekNumbers = true;
            this.cldDataInicio.TabIndex = 23;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 180);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(96, 21);
            this.lblDataInicio.TabIndex = 22;
            this.lblDataInicio.Text = "Data Início";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(16, 139);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 21;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(12, 115);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(16, 74);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Título";
            // 
            // lblEditarEvento
            // 
            this.lblEditarEvento.AutoSize = true;
            this.lblEditarEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditarEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditarEvento.Location = new System.Drawing.Point(12, 9);
            this.lblEditarEvento.Name = "lblEditarEvento";
            this.lblEditarEvento.Size = new System.Drawing.Size(109, 19);
            this.lblEditarEvento.TabIndex = 17;
            this.lblEditarEvento.Text = "Editar evento";
            this.lblEditarEvento.UseWaitCursor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.Location = new System.Drawing.Point(485, 452);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 34);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormEditarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 498);
            this.Controls.Add(this.btnSalvar);
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
            this.Controls.Add(this.lblEditarEvento);
            this.Name = "FormEditarEvento";
            this.Text = "MyAgenda | Editar Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtpHorarioTermino;
        private System.Windows.Forms.Label lblHorarioTermino;
        private System.Windows.Forms.MonthCalendar cldDataTermino;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.MonthCalendar cldDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEditarEvento;
        private System.Windows.Forms.Button btnSalvar;
    }
}