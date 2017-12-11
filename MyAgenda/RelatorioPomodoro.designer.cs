namespace MyAgenda
{
    partial class RelatorioPomodoro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_usuario,
            this.tipo,
            this.duracao_sessao,
            this.data_sessao});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // nome_usuario
            // 
            this.nome_usuario.DataPropertyName = "nome_usuario";
            this.nome_usuario.HeaderText = "Usuário";
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            this.nome_usuario.Width = 150;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo Sessão";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 130;
            // 
            // duracao_sessao
            // 
            this.duracao_sessao.DataPropertyName = "duracao_sessao";
            this.duracao_sessao.HeaderText = "Duração Sessão";
            this.duracao_sessao.Name = "duracao_sessao";
            this.duracao_sessao.ReadOnly = true;
            // 
            // data_sessao
            // 
            this.data_sessao.DataPropertyName = "data_sessao";
            this.data_sessao.HeaderText = "Data";
            this.data_sessao.Name = "data_sessao";
            this.data_sessao.ReadOnly = true;
            this.data_sessao.Width = 140;
            // 
            // RelatorioPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 333);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelatorioPomodoro";
            this.Text = "RelatorioPomodoro";
            this.Load += new System.EventHandler(this.RelatorioPomodoro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao_sessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sessao;
    }
}