﻿namespace MyAgenda
{
    partial class FormListaAfazeres
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
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
            this.panelListaAfazeres = new System.Windows.Forms.Panel();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblListaAfazeres = new System.Windows.Forms.Label();
            this.cbbListasAfazeres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barraNavegacao1
            // 
            this.barraNavegacao1.BackColor = System.Drawing.Color.LightSlateGray;
            this.barraNavegacao1.Cursor = System.Windows.Forms.Cursors.Default;
            this.barraNavegacao1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraNavegacao1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraNavegacao1.Location = new System.Drawing.Point(0, 0);
            this.barraNavegacao1.Name = "barraNavegacao1";
            this.barraNavegacao1.Size = new System.Drawing.Size(827, 40);
            this.barraNavegacao1.TabIndex = 0;
            // 
            // panelListaAfazeres
            // 
            this.panelListaAfazeres.Location = new System.Drawing.Point(288, 53);
            this.panelListaAfazeres.Name = "panelListaAfazeres";
            this.panelListaAfazeres.Size = new System.Drawing.Size(527, 408);
            this.panelListaAfazeres.TabIndex = 1;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataAtual.Location = new System.Drawing.Point(12, 53);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(111, 19);
            this.lblDataAtual.TabIndex = 2;
            this.lblDataAtual.Text = "<Data Atual>";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(16, 116);
            this.monthCalendar1.MaxDate = new System.DateTime(2095, 10, 21, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1995, 10, 21, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 3;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(13, 82);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(244, 17);
            this.lblDiaSemana.TabIndex = 4;
            this.lblDiaSemana.Text = "<Dia da semana e semana do ano>";
            // 
            // lblListaAfazeres
            // 
            this.lblListaAfazeres.AutoSize = true;
            this.lblListaAfazeres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaAfazeres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaAfazeres.Location = new System.Drawing.Point(12, 290);
            this.lblListaAfazeres.Name = "lblListaAfazeres";
            this.lblListaAfazeres.Size = new System.Drawing.Size(140, 21);
            this.lblListaAfazeres.TabIndex = 6;
            this.lblListaAfazeres.Text = "Lista de Afazeres";
            // 
            // cbbListasAfazeres
            // 
            this.cbbListasAfazeres.FormattingEnabled = true;
            this.cbbListasAfazeres.Location = new System.Drawing.Point(16, 314);
            this.cbbListasAfazeres.Name = "cbbListasAfazeres";
            this.cbbListasAfazeres.Size = new System.Drawing.Size(249, 21);
            this.cbbListasAfazeres.TabIndex = 7;
            this.cbbListasAfazeres.Text = "Selecionar Lista de Afazeres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tarefa";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(16, 384);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(249, 20);
            this.txtTarefa.TabIndex = 9;
            this.txtTarefa.Text = "Descrição da Tarefa";
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
            this.btnAdicionar.Location = new System.Drawing.Point(143, 423);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // FormListaAfazeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 469);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbListasAfazeres);
            this.Controls.Add(this.lblListaAfazeres);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.panelListaAfazeres);
            this.Controls.Add(this.barraNavegacao1);
            this.Name = "FormListaAfazeres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Lista de Afazeres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaAfazeres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.BarraNavegacao barraNavegacao1;
        private System.Windows.Forms.Panel panelListaAfazeres;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblListaAfazeres;
        private System.Windows.Forms.ComboBox cbbListasAfazeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Button btnAdicionar;
    }
}