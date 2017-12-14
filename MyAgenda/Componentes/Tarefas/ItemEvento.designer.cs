namespace MyAgenda.Componentes.Tarefas
{
    partial class ItemEvento
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrioridade = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblHoraInicioHoraFim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPrioridade
            // 
            this.pnlPrioridade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPrioridade.Location = new System.Drawing.Point(0, 0);
            this.pnlPrioridade.Name = "pnlPrioridade";
            this.pnlPrioridade.Size = new System.Drawing.Size(24, 104);
            this.pnlPrioridade.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título do Evento";
            this.lblTitulo.MouseEnter += new System.EventHandler(this.lblTitulo_MouseEnter);
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(31, 34);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(143, 17);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição do Evento";
            this.lblDescricao.MouseEnter += new System.EventHandler(this.lblDescricao_MouseEnter);
            this.lblDescricao.MouseLeave += new System.EventHandler(this.lblDescricao_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackgroundImage = global::MyAgenda.Properties.Resources.ic_mode_edit_black_18dp_1x;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(508, 73);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 28);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackgroundImage = global::MyAgenda.Properties.Resources.ic_delete_black;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(558, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(44, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.btnExcluir_MouseEnter);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnExcluir_MouseLeave);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(32, 69);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(151, 17);
            this.lblDataInicio.TabIndex = 6;
            this.lblDataInicio.Text = "Data início do evento";
            this.lblDataInicio.MouseEnter += new System.EventHandler(this.lblDataInicio_MouseEnter);
            this.lblDataInicio.MouseLeave += new System.EventHandler(this.lblDataInicio_MouseLeave);
            // 
            // lblHoraInicioHoraFim
            // 
            this.lblHoraInicioHoraFim.AutoSize = true;
            this.lblHoraInicioHoraFim.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.lblHoraInicioHoraFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoraInicioHoraFim.Location = new System.Drawing.Point(32, 86);
            this.lblHoraInicioHoraFim.Name = "lblHoraInicioHoraFim";
            this.lblHoraInicioHoraFim.Size = new System.Drawing.Size(135, 17);
            this.lblHoraInicioHoraFim.TabIndex = 7;
            this.lblHoraInicioHoraFim.Text = "Hora Início  - Hora Fim";
            this.lblHoraInicioHoraFim.MouseEnter += new System.EventHandler(this.lblHoraInicioHoraFim_MouseEnter);
            this.lblHoraInicioHoraFim.MouseLeave += new System.EventHandler(this.lblHoraInicioHoraFim_MouseLeave);
            // 
            // ItemEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblHoraInicioHoraFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlPrioridade);
            this.Name = "ItemEvento";
            this.Size = new System.Drawing.Size(605, 104);
            this.MouseEnter += new System.EventHandler(this.ItemEvento_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemTarefa_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrioridade;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblHoraInicioHoraFim;
    }
}
