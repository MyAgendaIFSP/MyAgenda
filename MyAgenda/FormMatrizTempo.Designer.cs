﻿namespace MyAgenda
{
    partial class FormMatrizTempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrizTempo));
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnQuad4 = new System.Windows.Forms.Button();
            this.btnQuad1 = new System.Windows.Forms.Button();
            this.btnQuad3 = new System.Windows.Forms.Button();
            this.btnQuad2 = new System.Windows.Forms.Button();
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMatriz
            // 
            this.panelMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMatriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatriz.Location = new System.Drawing.Point(288, 53);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(527, 408);
            this.panelMatriz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicionar atividade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quadrante";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(16, 115);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 27);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 175);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 27);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnQuad4
            // 
            this.btnQuad4.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnQuad4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuad4.FlatAppearance.BorderSize = 0;
            this.btnQuad4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnQuad4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuad4.ForeColor = System.Drawing.Color.White;
            this.btnQuad4.Location = new System.Drawing.Point(14, 236);
            this.btnQuad4.Name = "btnQuad4";
            this.btnQuad4.Size = new System.Drawing.Size(129, 77);
            this.btnQuad4.TabIndex = 6;
            this.btnQuad4.Text = "4";
            this.btnQuad4.UseVisualStyleBackColor = false;
            this.btnQuad4.MouseEnter += new System.EventHandler(this.btnQuad4_MouseEnter);
            // 
            // btnQuad1
            // 
            this.btnQuad1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnQuad1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuad1.FlatAppearance.BorderSize = 0;
            this.btnQuad1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnQuad1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuad1.ForeColor = System.Drawing.Color.White;
            this.btnQuad1.Location = new System.Drawing.Point(144, 236);
            this.btnQuad1.Name = "btnQuad1";
            this.btnQuad1.Size = new System.Drawing.Size(129, 77);
            this.btnQuad1.TabIndex = 3;
            this.btnQuad1.Text = "1";
            this.btnQuad1.UseVisualStyleBackColor = false;
            this.btnQuad1.MouseEnter += new System.EventHandler(this.btnQuad1_MouseEnter);
            // 
            // btnQuad3
            // 
            this.btnQuad3.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnQuad3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuad3.FlatAppearance.BorderSize = 0;
            this.btnQuad3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnQuad3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuad3.ForeColor = System.Drawing.Color.White;
            this.btnQuad3.Location = new System.Drawing.Point(14, 314);
            this.btnQuad3.Name = "btnQuad3";
            this.btnQuad3.Size = new System.Drawing.Size(129, 77);
            this.btnQuad3.TabIndex = 5;
            this.btnQuad3.Text = "3";
            this.btnQuad3.UseVisualStyleBackColor = false;
            this.btnQuad3.MouseEnter += new System.EventHandler(this.btnQuad3_MouseEnter);
            // 
            // btnQuad2
            // 
            this.btnQuad2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnQuad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuad2.FlatAppearance.BorderSize = 0;
            this.btnQuad2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnQuad2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuad2.ForeColor = System.Drawing.Color.White;
            this.btnQuad2.Location = new System.Drawing.Point(144, 314);
            this.btnQuad2.Name = "btnQuad2";
            this.btnQuad2.Size = new System.Drawing.Size(129, 77);
            this.btnQuad2.TabIndex = 4;
            this.btnQuad2.Text = "2";
            this.btnQuad2.UseVisualStyleBackColor = false;
            this.btnQuad2.MouseEnter += new System.EventHandler(this.btnQuad2_MouseEnter);
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
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::MyAgenda.Properties.Resources.ic_add_circle_black;
            this.btnAdicionar.Location = new System.Drawing.Point(149, 427);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.btnAdicionar_MouseEnter);
            this.btnAdicionar.MouseLeave += new System.EventHandler(this.btnAdicionar_MouseLeave);
            // 
            // FormMatrizTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnQuad2);
            this.Controls.Add(this.btnQuad3);
            this.Controls.Add(this.btnQuad1);
            this.Controls.Add(this.btnQuad4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.barraNavegacao1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMatrizTempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Matriz do Tempo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.BarraNavegacao barraNavegacao1;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnQuad4;
        private System.Windows.Forms.Button btnQuad1;
        private System.Windows.Forms.Button btnQuad3;
        private System.Windows.Forms.Button btnQuad2;
        private System.Windows.Forms.Button btnAdicionar;
    }
}