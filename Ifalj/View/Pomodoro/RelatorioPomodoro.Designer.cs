namespace Ifalj.View.Pomodoro
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
            this.components = new System.ComponentModel.Container();
            this.bDIFALJDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pomodoroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vwrelatoriopomodoroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_IFALJDataSetFinal = new Ifalj.BD_IFALJDataSetFinal();
            this.vwrelatoriopomodoroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwrelatoriopomodoroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_relatorio_pomodoroTableAdapter2 = new Ifalj.BD_IFALJDataSetFinalTableAdapters.vw_relatorio_pomodoroTableAdapter();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDIFALJDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_IFALJDataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pomodoroBindingSource
            // 
            this.pomodoroBindingSource.DataMember = "pomodoro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_usuario,
            this.tipo,
            this.duracao_sessao,
            this.data_sessao});
            this.dataGridView1.DataSource = this.vwrelatoriopomodoroBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // vwrelatoriopomodoroBindingSource2
            // 
            this.vwrelatoriopomodoroBindingSource2.DataMember = "vw_relatorio_pomodoro";
            this.vwrelatoriopomodoroBindingSource2.DataSource = this.bD_IFALJDataSetFinal;
            // 
            // bD_IFALJDataSetFinal
            // 
            this.bD_IFALJDataSetFinal.DataSetName = "BD_IFALJDataSetFinal";
            this.bD_IFALJDataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwrelatoriopomodoroBindingSource
            // 
            this.vwrelatoriopomodoroBindingSource.DataMember = "vw_relatorio_pomodoro";
            // 
            // vwrelatoriopomodoroBindingSource1
            // 
            this.vwrelatoriopomodoroBindingSource1.DataMember = "vw_relatorio_pomodoro";
            // 
            // vw_relatorio_pomodoroTableAdapter2
            // 
            this.vw_relatorio_pomodoroTableAdapter2.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bDIFALJDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_IFALJDataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrelatoriopomodoroBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bDIFALJDataSetBindingSource;
        private System.Windows.Forms.BindingSource pomodoroBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vwrelatoriopomodoroBindingSource;
        private System.Windows.Forms.BindingSource vwrelatoriopomodoroBindingSource1;
        private BD_IFALJDataSetFinal bD_IFALJDataSetFinal;
        private System.Windows.Forms.BindingSource vwrelatoriopomodoroBindingSource2;
        private BD_IFALJDataSetFinalTableAdapters.vw_relatorio_pomodoroTableAdapter vw_relatorio_pomodoroTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao_sessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sessao;
    }
}