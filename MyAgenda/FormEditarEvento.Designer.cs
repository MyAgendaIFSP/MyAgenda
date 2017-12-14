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
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.btnSalvarEdicao = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
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
            this.txtDescricao.Location = new System.Drawing.Point(291, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(16, 62);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(287, 38);
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
            this.lblTitulo.Location = new System.Drawing.Point(12, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Título";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 102);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(96, 21);
            this.lblDataInicio.TabIndex = 22;
            this.lblDataInicio.Text = "Data Início";
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDataTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataTermino.Location = new System.Drawing.Point(287, 102);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(116, 21);
            this.lblDataTermino.TabIndex = 26;
            this.lblDataTermino.Text = "Data Término";
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarEdicao.AutoSize = true;
            this.btnSalvarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEdicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalvarEdicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarEdicao.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnSalvarEdicao.Location = new System.Drawing.Point(398, 265);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(146, 34);
            this.btnSalvarEdicao.TabIndex = 30;
            this.btnSalvarEdicao.Text = "Salvar Edição";
            this.btnSalvarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvarEdicao.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            this.btnSalvarEdicao.MouseEnter += new System.EventHandler(this.btnSalvarEdicao_MouseEnter);
            this.btnSalvarEdicao.MouseLeave += new System.EventHandler(this.btnSalvarEdicao_MouseLeave);
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(16, 126);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(255, 27);
            this.dtpInicio.TabIndex = 31;
            this.dtpInicio.Value = new System.DateTime(2017, 12, 9, 17, 47, 25, 0);
            // 
            // dtpTermino
            // 
            this.dtpTermino.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTermino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermino.Location = new System.Drawing.Point(289, 126);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(255, 27);
            this.dtpTermino.TabIndex = 32;
            this.dtpTermino.Value = new System.DateTime(2017, 12, 9, 17, 47, 25, 0);
            // 
            // FormEditarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnSalvarEdicao);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEditarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.Button btnSalvarEdicao;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
    }
}