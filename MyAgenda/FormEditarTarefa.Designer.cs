namespace MyAgenda
{
    partial class FormEditarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarTarefa));
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.btnSalvarEdicao = new System.Windows.Forms.Button();
            this.cldData = new System.Windows.Forms.MonthCalendar();
            this.lblData = new System.Windows.Forms.Label();
            this.cbbListasAfazeres = new System.Windows.Forms.ComboBox();
            this.lblListaAfazeres = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblEditarTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.AutoSize = true;
            this.btnNovaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovaLista.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnNovaLista.Location = new System.Drawing.Point(150, 165);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(121, 33);
            this.btnNovaLista.TabIndex = 31;
            this.btnNovaLista.Text = "Nova Lista";
            this.btnNovaLista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovaLista.UseVisualStyleBackColor = true;
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
            this.btnSalvarEdicao.Location = new System.Drawing.Point(127, 419);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(146, 34);
            this.btnSalvarEdicao.TabIndex = 30;
            this.btnSalvarEdicao.Text = "Salvar Edição";
            this.btnSalvarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvarEdicao.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // cldData
            // 
            this.cldData.Location = new System.Drawing.Point(16, 237);
            this.cldData.Name = "cldData";
            this.cldData.TabIndex = 29;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(12, 207);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 21);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "Data";
            // 
            // cbbListasAfazeres
            // 
            this.cbbListasAfazeres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListasAfazeres.FormattingEnabled = true;
            this.cbbListasAfazeres.Location = new System.Drawing.Point(16, 130);
            this.cbbListasAfazeres.Name = "cbbListasAfazeres";
            this.cbbListasAfazeres.Size = new System.Drawing.Size(255, 29);
            this.cbbListasAfazeres.TabIndex = 27;
            // 
            // lblListaAfazeres
            // 
            this.lblListaAfazeres.AutoSize = true;
            this.lblListaAfazeres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblListaAfazeres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaAfazeres.Location = new System.Drawing.Point(12, 106);
            this.lblListaAfazeres.Name = "lblListaAfazeres";
            this.lblListaAfazeres.Size = new System.Drawing.Size(140, 21);
            this.lblListaAfazeres.TabIndex = 26;
            this.lblListaAfazeres.Text = "Lista de Afazeres";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTarefa.Location = new System.Drawing.Point(16, 71);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(255, 27);
            this.txtTarefa.TabIndex = 24;
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTarefa.Location = new System.Drawing.Point(12, 47);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(60, 21);
            this.lblTarefa.TabIndex = 25;
            this.lblTarefa.Text = "Tarefa";
            // 
            // lblEditarTarefa
            // 
            this.lblEditarTarefa.AutoSize = true;
            this.lblEditarTarefa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditarTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditarTarefa.Location = new System.Drawing.Point(12, 9);
            this.lblEditarTarefa.Name = "lblEditarTarefa";
            this.lblEditarTarefa.Size = new System.Drawing.Size(118, 21);
            this.lblEditarTarefa.TabIndex = 23;
            this.lblEditarTarefa.Text = "EditarTarefa";
            // 
            // FormEditarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 465);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.btnSalvarEdicao);
            this.Controls.Add(this.cldData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbbListasAfazeres);
            this.Controls.Add(this.lblListaAfazeres);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblEditarTarefa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarTarefa";
            this.Text = "MyAgenda | Editar Tarefa";
            this.Load += new System.EventHandler(this.FormEditarTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.Button btnSalvarEdicao;
        private System.Windows.Forms.MonthCalendar cldData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbbListasAfazeres;
        private System.Windows.Forms.Label lblListaAfazeres;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblEditarTarefa;
    }
}