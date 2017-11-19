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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaAfazeres));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblListaAfazeres = new System.Windows.Forms.Label();
            this.cbbListasAfazeres = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cldData = new System.Windows.Forms.MonthCalendar();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlListaAfazeres = new System.Windows.Forms.Panel();
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar tarefa";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTarefa.Location = new System.Drawing.Point(16, 115);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(255, 27);
            this.txtTarefa.TabIndex = 13;
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTarefa.Location = new System.Drawing.Point(12, 91);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(60, 21);
            this.lblTarefa.TabIndex = 14;
            this.lblTarefa.Text = "Tarefa";
            // 
            // lblListaAfazeres
            // 
            this.lblListaAfazeres.AutoSize = true;
            this.lblListaAfazeres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblListaAfazeres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaAfazeres.Location = new System.Drawing.Point(12, 150);
            this.lblListaAfazeres.Name = "lblListaAfazeres";
            this.lblListaAfazeres.Size = new System.Drawing.Size(140, 21);
            this.lblListaAfazeres.TabIndex = 15;
            this.lblListaAfazeres.Text = "Lista de Afazeres";
            // 
            // cbbListasAfazeres
            // 
            this.cbbListasAfazeres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListasAfazeres.FormattingEnabled = true;
            this.cbbListasAfazeres.Location = new System.Drawing.Point(16, 174);
            this.cbbListasAfazeres.Name = "cbbListasAfazeres";
            this.cbbListasAfazeres.Size = new System.Drawing.Size(255, 29);
            this.cbbListasAfazeres.TabIndex = 16;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(12, 251);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 21);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data";
            // 
            // cldData
            // 
            this.cldData.Location = new System.Drawing.Point(16, 281);
            this.cldData.Name = "cldData";
            this.cldData.TabIndex = 19;
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
            this.btnAdicionar.Location = new System.Drawing.Point(149, 466);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 20;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlListaAfazeres
            // 
            this.pnlListaAfazeres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaAfazeres.Location = new System.Drawing.Point(288, 53);
            this.pnlListaAfazeres.Name = "pnlListaAfazeres";
            this.pnlListaAfazeres.Size = new System.Drawing.Size(527, 408);
            this.pnlListaAfazeres.TabIndex = 21;
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
            // btnNovaLista
            // 
            this.btnNovaLista.AutoSize = true;
            this.btnNovaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovaLista.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnNovaLista.Location = new System.Drawing.Point(150, 209);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(121, 33);
            this.btnNovaLista.TabIndex = 22;
            this.btnNovaLista.Text = "Nova Lista";
            this.btnNovaLista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // FormListaAfazeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 512);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.pnlListaAfazeres);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cldData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbbListasAfazeres);
            this.Controls.Add(this.lblListaAfazeres);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraNavegacao1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblListaAfazeres;
        private System.Windows.Forms.ComboBox cbbListasAfazeres;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MonthCalendar cldData;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel pnlListaAfazeres;
        private System.Windows.Forms.Button btnNovaLista;
    }
}