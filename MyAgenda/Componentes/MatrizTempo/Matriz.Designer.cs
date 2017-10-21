using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    partial class Matriz
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpQuad2 = new System.Windows.Forms.GroupBox();
            this.gpQuad3 = new System.Windows.Forms.GroupBox();
            this.gpQuad4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.verticalLabel1 = new MyAgenda.Componentes.MatrizTempo.VerticalLabel();
            this.verticalLabel2 = new MyAgenda.Componentes.MatrizTempo.VerticalLabel();
            this.gpQuad1 = new System.Windows.Forms.GroupBox();
            this.panelQuad1 = new System.Windows.Forms.Panel();
            this.panelQuad2 = new System.Windows.Forms.Panel();
            this.panelQuad3 = new System.Windows.Forms.Panel();
            this.panelQuad4 = new System.Windows.Forms.Panel();
            this.gpQuad2.SuspendLayout();
            this.gpQuad3.SuspendLayout();
            this.gpQuad4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpQuad1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "URGENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "NÃO URGENTES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpQuad2
            // 
            this.gpQuad2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuad2.BackColor = System.Drawing.Color.White;
            this.gpQuad2.Controls.Add(this.panelQuad2);
            this.gpQuad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpQuad2.Location = new System.Drawing.Point(5, 24);
            this.gpQuad2.Name = "gpQuad2";
            this.gpQuad2.Size = new System.Drawing.Size(340, 219);
            this.gpQuad2.TabIndex = 7;
            this.gpQuad2.TabStop = false;
            this.gpQuad2.Text = "II - Qualidade";
            // 
            // gpQuad3
            // 
            this.gpQuad3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuad3.BackColor = System.Drawing.Color.White;
            this.gpQuad3.Controls.Add(this.panelQuad3);
            this.gpQuad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpQuad3.Location = new System.Drawing.Point(29, 5);
            this.gpQuad3.Name = "gpQuad3";
            this.gpQuad3.Size = new System.Drawing.Size(314, 240);
            this.gpQuad3.TabIndex = 8;
            this.gpQuad3.TabStop = false;
            this.gpQuad3.Text = "III - Ilusão";
            // 
            // gpQuad4
            // 
            this.gpQuad4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuad4.BackColor = System.Drawing.Color.White;
            this.gpQuad4.Controls.Add(this.panelQuad4);
            this.gpQuad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpQuad4.Location = new System.Drawing.Point(5, 5);
            this.gpQuad4.Name = "gpQuad4";
            this.gpQuad4.Size = new System.Drawing.Size(340, 240);
            this.gpQuad4.TabIndex = 9;
            this.gpQuad4.TabStop = false;
            this.gpQuad4.Text = "IV - Desperdício";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gpQuad1);
            this.panel1.Controls.Add(this.verticalLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 250);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gpQuad2);
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 250);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gpQuad4);
            this.panel4.Location = new System.Drawing.Point(349, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 250);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.verticalLabel2);
            this.panel3.Controls.Add(this.gpQuad3);
            this.panel3.Location = new System.Drawing.Point(0, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 250);
            this.panel3.TabIndex = 12;
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.verticalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalLabel1.Location = new System.Drawing.Point(-1, 0);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.Size = new System.Drawing.Size(24, 248);
            this.verticalLabel1.TabIndex = 0;
            this.verticalLabel1.Text = "IMPORTANTES";
            // 
            // verticalLabel2
            // 
            this.verticalLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalLabel2.BackColor = System.Drawing.Color.SkyBlue;
            this.verticalLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalLabel2.Location = new System.Drawing.Point(-1, -1);
            this.verticalLabel2.Name = "verticalLabel2";
            this.verticalLabel2.Size = new System.Drawing.Size(24, 250);
            this.verticalLabel2.TabIndex = 1;
            this.verticalLabel2.Text = "NÃO IMPORTANTES";
            this.verticalLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpQuad1
            // 
            this.gpQuad1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuad1.BackColor = System.Drawing.Color.White;
            this.gpQuad1.Controls.Add(this.panelQuad1);
            this.gpQuad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpQuad1.Location = new System.Drawing.Point(29, 24);
            this.gpQuad1.Name = "gpQuad1";
            this.gpQuad1.Size = new System.Drawing.Size(314, 219);
            this.gpQuad1.TabIndex = 6;
            this.gpQuad1.TabStop = false;
            this.gpQuad1.Text = "I - Estresse";
            // 
            // panelQuad1
            // 
            this.panelQuad1.AutoScroll = true;
            this.panelQuad1.AutoSize = true;
            this.panelQuad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuad1.Location = new System.Drawing.Point(3, 23);
            this.panelQuad1.Name = "panelQuad1";
            this.panelQuad1.Size = new System.Drawing.Size(308, 193);
            this.panelQuad1.TabIndex = 0;
            // 
            // panelQuad2
            // 
            this.panelQuad2.AutoScroll = true;
            this.panelQuad2.AutoSize = true;
            this.panelQuad2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuad2.Location = new System.Drawing.Point(3, 23);
            this.panelQuad2.Name = "panelQuad2";
            this.panelQuad2.Size = new System.Drawing.Size(334, 193);
            this.panelQuad2.TabIndex = 0;
            // 
            // panelQuad3
            // 
            this.panelQuad3.AutoScroll = true;
            this.panelQuad3.AutoSize = true;
            this.panelQuad3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuad3.Location = new System.Drawing.Point(3, 23);
            this.panelQuad3.Name = "panelQuad3";
            this.panelQuad3.Size = new System.Drawing.Size(308, 214);
            this.panelQuad3.TabIndex = 0;
            // 
            // panelQuad4
            // 
            this.panelQuad4.AutoScroll = true;
            this.panelQuad4.AutoSize = true;
            this.panelQuad4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuad4.Location = new System.Drawing.Point(3, 23);
            this.panelQuad4.Name = "panelQuad4";
            this.panelQuad4.Size = new System.Drawing.Size(334, 214);
            this.panelQuad4.TabIndex = 1;
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Matriz";
            this.Size = new System.Drawing.Size(700, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Matriz_Paint);
            this.gpQuad2.ResumeLayout(false);
            this.gpQuad2.PerformLayout();
            this.gpQuad3.ResumeLayout(false);
            this.gpQuad3.PerformLayout();
            this.gpQuad4.ResumeLayout(false);
            this.gpQuad4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gpQuad1.ResumeLayout(false);
            this.gpQuad1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalLabel verticalLabel2;
        private Label label1;
        private Label label2;
        private GroupBox gpQuad2;
        private GroupBox gpQuad3;
        private GroupBox gpQuad4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private VerticalLabel verticalLabel1;
        private GroupBox gpQuad1;
        private Panel panelQuad1;
        private Panel panelQuad2;
        private Panel panelQuad3;
        private Panel panelQuad4;
    }
}
