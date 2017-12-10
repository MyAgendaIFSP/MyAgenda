namespace MyAgenda
{
    partial class FormListaContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaContatos));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBuscarContato = new System.Windows.Forms.ComboBox();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contatoLista = new MyAgenda.Componentes.ListaContatos.Contato.ContatoLista();
            this.label2 = new System.Windows.Forms.Label();
            this.timerAtualizaContatos = new System.Windows.Forms.Timer(this.components);
            this.timerBuscaContato = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar contato:";
            // 
            // cbbBuscarContato
            // 
            this.cbbBuscarContato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBuscarContato.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbBuscarContato.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbbBuscarContato.Location = new System.Drawing.Point(10, 54);
            this.cbbBuscarContato.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBuscarContato.Name = "cbbBuscarContato";
            this.cbbBuscarContato.Size = new System.Drawing.Size(271, 25);
            this.cbbBuscarContato.TabIndex = 4;
            this.cbbBuscarContato.TextUpdate += new System.EventHandler(this.cbbBuscarContato_TextUpdate);
            // 
            // btnAddContato
            // 
            this.btnAddContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddContato.BackColor = System.Drawing.Color.White;
            this.btnAddContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddContato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnAddContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContato.ForeColor = System.Drawing.Color.Black;
            this.btnAddContato.Image = global::MyAgenda.Properties.Resources.ic_person_add_black_24dp;
            this.btnAddContato.Location = new System.Drawing.Point(287, 52);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(30, 30);
            this.btnAddContato.TabIndex = 5;
            this.btnAddContato.UseVisualStyleBackColor = false;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            this.btnAddContato.MouseEnter += new System.EventHandler(this.btnAddContato_MouseEnter);
            this.btnAddContato.MouseLeave += new System.EventHandler(this.btnAddContato_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.contatoLista);
            this.groupBox1.Location = new System.Drawing.Point(10, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 415);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contatos";
            // 
            // contatoLista
            // 
            this.contatoLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contatoLista.Location = new System.Drawing.Point(3, 20);
            this.contatoLista.Name = "contatoLista";
            this.contatoLista.Size = new System.Drawing.Size(301, 392);
            this.contatoLista.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contatos";
            // 
            // timerAtualizaContatos
            // 
            this.timerAtualizaContatos.Enabled = true;
            this.timerAtualizaContatos.Interval = 2000;
            this.timerAtualizaContatos.Tick += new System.EventHandler(this.timerAtualizaContatos_Tick);
            // 
            // timerBuscaContato
            // 
            this.timerBuscaContato.Interval = 1000;
            this.timerBuscaContato.Tick += new System.EventHandler(this.timerBuscaContato_Tick);
            // 
            // FormListaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddContato);
            this.Controls.Add(this.cbbBuscarContato);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormListaContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyAgenda - Contatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contatos_FormClosed);
            this.Load += new System.EventHandler(this.Contatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBuscarContato;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Componentes.ListaContatos.Contato.ContatoLista contatoLista;
        private System.Windows.Forms.Timer timerAtualizaContatos;
        private System.Windows.Forms.Timer timerBuscaContato;
    }
}