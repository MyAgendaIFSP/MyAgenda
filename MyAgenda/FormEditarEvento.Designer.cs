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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarEvento));
            this.lblEditarEvento = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cldDataInicio = new System.Windows.Forms.MonthCalendar();
            this.dtpHorarioInicial = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpHorarioTermino = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioTermino = new System.Windows.Forms.Label();
            this.cldDataTermino = new System.Windows.Forms.MonthCalendar();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.btnSalvarEdicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditarEvento
            // 
            this.lblEditarEvento.AutoSize = true;
            this.lblEditarEvento.BackColor = System.Drawing.Color.White;
            this.lblEditarEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditarEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditarEvento.Location = new System.Drawing.Point(12, 9);
            this.lblEditarEvento.Name = "lblEditarEvento";
            this.lblEditarEvento.Size = new System.Drawing.Size(130, 21);
            this.lblEditarEvento.TabIndex = 12;
            this.lblEditarEvento.Text = "Editar evento";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(16, 140);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(16, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(12, 116);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Título";
            // 
            // cldDataInicio
            // 
            this.cldDataInicio.Location = new System.Drawing.Point(16, 205);
            this.cldDataInicio.MaxSelectionCount = 1;
            this.cldDataInicio.Name = "cldDataInicio";
            this.cldDataInicio.TabIndex = 25;
            // 
            // dtpHorarioInicial
            // 
            this.dtpHorarioInicial.AllowDrop = true;
            this.dtpHorarioInicial.CustomFormat = "";
            this.dtpHorarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicial.Location = new System.Drawing.Point(16, 400);
            this.dtpHorarioInicial.Name = "dtpHorarioInicial";
            this.dtpHorarioInicial.ShowUpDown = true;
            this.dtpHorarioInicial.Size = new System.Drawing.Size(255, 20);
            this.dtpHorarioInicial.TabIndex = 24;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioInicio.Location = new System.Drawing.Point(12, 376);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioInicio.TabIndex = 23;
            this.lblHorarioInicio.Text = "Horário Início";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 175);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(96, 21);
            this.lblDataInicio.TabIndex = 22;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dtpHorarioTermino
            // 
            this.dtpHorarioTermino.AllowDrop = true;
            this.dtpHorarioTermino.CustomFormat = "";
            this.dtpHorarioTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioTermino.Location = new System.Drawing.Point(340, 400);
            this.dtpHorarioTermino.Name = "dtpHorarioTermino";
            this.dtpHorarioTermino.ShowUpDown = true;
            this.dtpHorarioTermino.Size = new System.Drawing.Size(255, 20);
            this.dtpHorarioTermino.TabIndex = 29;
            // 
            // lblHorarioTermino
            // 
            this.lblHorarioTermino.AutoSize = true;
            this.lblHorarioTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHorarioTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHorarioTermino.Location = new System.Drawing.Point(336, 376);
            this.lblHorarioTermino.Name = "lblHorarioTermino";
            this.lblHorarioTermino.Size = new System.Drawing.Size(110, 21);
            this.lblHorarioTermino.TabIndex = 28;
            this.lblHorarioTermino.Text = "Horário Início";
            // 
            // cldDataTermino
            // 
            this.cldDataTermino.Location = new System.Drawing.Point(340, 205);
            this.cldDataTermino.MaxSelectionCount = 1;
            this.cldDataTermino.Name = "cldDataTermino";
            this.cldDataTermino.TabIndex = 27;
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(336, 175);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 26;
            this.lblDataTermino.Text = "Data Término";
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarEdicao.AutoSize = true;
            this.btnSalvarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEdicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalvarEdicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarEdicao.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnSalvarEdicao.Location = new System.Drawing.Point(449, 463);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(146, 34);
            this.btnSalvarEdicao.TabIndex = 30;
            this.btnSalvarEdicao.Text = "Salvar Edição";
            this.btnSalvarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvarEdicao.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // FormEditarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 509);
            this.Controls.Add(this.btnSalvarEdicao);
            this.Controls.Add(this.dtpHorarioTermino);
            this.Controls.Add(this.lblHorarioTermino);
            this.Controls.Add(this.cldDataTermino);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.cldDataInicio);
            this.Controls.Add(this.dtpHorarioInicial);
            this.Controls.Add(this.lblHorarioInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEditarEvento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarEvento";
            this.Text = "MyAgenda | Editar Evento";
            this.Load += new System.EventHandler(this.FormEditarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarEvento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MonthCalendar cldDataInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicial;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioTermino;
        private System.Windows.Forms.Label lblHorarioTermino;
        private System.Windows.Forms.MonthCalendar cldDataTermino;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.Button btnSalvarEdicao;
    }
}