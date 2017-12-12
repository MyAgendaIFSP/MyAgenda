namespace MyAgenda
{
    partial class FormPomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPomodoro));
            this.txtQuadroColor1 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor2 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor3 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor4 = new System.Windows.Forms.TextBox();
            this.tmrPomodoro = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelatorioPomodoro = new System.Windows.Forms.Button();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.cclPbrPomodoro = new MyAgenda.Componentes.Pomodoro.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRelogio = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.tmrAlternaCor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRelogio.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraNavegacao
            // 
            this.BarraNavegacao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BarraNavegacao.Size = new System.Drawing.Size(612, 40);
            // 
            // Loader
            // 
            this.Loader.Size = new System.Drawing.Size(596, 7);
            // 
            // txtQuadroColor1
            // 
            this.txtQuadroColor1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuadroColor1.Enabled = false;
            this.txtQuadroColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuadroColor1.Location = new System.Drawing.Point(5, 5);
            this.txtQuadroColor1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor1.Multiline = true;
            this.txtQuadroColor1.Name = "txtQuadroColor1";
            this.txtQuadroColor1.ReadOnly = true;
            this.txtQuadroColor1.Size = new System.Drawing.Size(145, 98);
            this.txtQuadroColor1.TabIndex = 3;
            // 
            // txtQuadroColor2
            // 
            this.txtQuadroColor2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuadroColor2.Enabled = false;
            this.txtQuadroColor2.Location = new System.Drawing.Point(155, 4);
            this.txtQuadroColor2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor2.Multiline = true;
            this.txtQuadroColor2.Name = "txtQuadroColor2";
            this.txtQuadroColor2.ReadOnly = true;
            this.txtQuadroColor2.Size = new System.Drawing.Size(145, 98);
            this.txtQuadroColor2.TabIndex = 4;
            // 
            // txtQuadroColor3
            // 
            this.txtQuadroColor3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuadroColor3.Enabled = false;
            this.txtQuadroColor3.Location = new System.Drawing.Point(304, 4);
            this.txtQuadroColor3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor3.Multiline = true;
            this.txtQuadroColor3.Name = "txtQuadroColor3";
            this.txtQuadroColor3.ReadOnly = true;
            this.txtQuadroColor3.Size = new System.Drawing.Size(145, 98);
            this.txtQuadroColor3.TabIndex = 5;
            // 
            // txtQuadroColor4
            // 
            this.txtQuadroColor4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuadroColor4.Enabled = false;
            this.txtQuadroColor4.Location = new System.Drawing.Point(453, 4);
            this.txtQuadroColor4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor4.Multiline = true;
            this.txtQuadroColor4.Name = "txtQuadroColor4";
            this.txtQuadroColor4.ReadOnly = true;
            this.txtQuadroColor4.Size = new System.Drawing.Size(145, 98);
            this.txtQuadroColor4.TabIndex = 6;
            // 
            // tmrPomodoro
            // 
            this.tmrPomodoro.Interval = 10;
            this.tmrPomodoro.Tick += new System.EventHandler(this.tmrPomodoro_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(434, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sessões";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.duracao_sessao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tipo";
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // duracao_sessao
            // 
            this.duracao_sessao.DataPropertyName = "duracao_sessao";
            this.duracao_sessao.HeaderText = "Duração";
            this.duracao_sessao.Name = "duracao_sessao";
            this.duracao_sessao.ReadOnly = true;
            this.duracao_sessao.Width = 300;
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.SlateGray;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.Color.White;
            this.btnPausar.Location = new System.Drawing.Point(160, 321);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(142, 41);
            this.btnPausar.TabIndex = 7;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.SlateGray;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(14, 321);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 41);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.SlateGray;
            this.btnPomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPomodoro.FlatAppearance.BorderSize = 0;
            this.btnPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnPomodoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomodoro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnPomodoro.Location = new System.Drawing.Point(14, 5);
            this.btnPomodoro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(142, 40);
            this.btnPomodoro.TabIndex = 9;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.BackColor = System.Drawing.Color.SlateGray;
            this.btnShortBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortBreak.FlatAppearance.BorderSize = 0;
            this.btnShortBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnShortBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortBreak.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortBreak.ForeColor = System.Drawing.Color.White;
            this.btnShortBreak.Location = new System.Drawing.Point(160, 5);
            this.btnShortBreak.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(142, 40);
            this.btnShortBreak.TabIndex = 10;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = false;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.BackColor = System.Drawing.Color.SlateGray;
            this.btnLongBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLongBreak.FlatAppearance.BorderSize = 0;
            this.btnLongBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnLongBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLongBreak.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongBreak.ForeColor = System.Drawing.Color.White;
            this.btnLongBreak.Location = new System.Drawing.Point(306, 5);
            this.btnLongBreak.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(142, 40);
            this.btnLongBreak.TabIndex = 11;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = false;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.SlateGray;
            this.btnResetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetar.FlatAppearance.BorderSize = 0;
            this.btnResetar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnResetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar.ForeColor = System.Drawing.Color.White;
            this.btnResetar.Location = new System.Drawing.Point(306, 321);
            this.btnResetar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(142, 41);
            this.btnResetar.TabIndex = 12;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // nudTempo
            // 
            this.nudTempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudTempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTempo.Location = new System.Drawing.Point(12, 410);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(434, 27);
            this.nudTempo.TabIndex = 15;
            this.nudTempo.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTempo.ValueChanged += new System.EventHandler(this.nudTempo_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRelatorioPomodoro);
            this.panel1.Controls.Add(this.nudTempo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnResetar);
            this.panel1.Controls.Add(this.btnPausar);
            this.panel1.Controls.Add(this.btnLongBreak);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.btnShortBreak);
            this.panel1.Controls.Add(this.btnPomodoro);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(618, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 523);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Entre o tempo desejado em minutos";
            // 
            // btnRelatorioPomodoro
            // 
            this.btnRelatorioPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorioPomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioPomodoro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRelatorioPomodoro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRelatorioPomodoro.Location = new System.Drawing.Point(276, 473);
            this.btnRelatorioPomodoro.Name = "btnRelatorioPomodoro";
            this.btnRelatorioPomodoro.Size = new System.Drawing.Size(172, 39);
            this.btnRelatorioPomodoro.TabIndex = 18;
            this.btnRelatorioPomodoro.Text = "Ranking Pomodoro";
            this.btnRelatorioPomodoro.UseVisualStyleBackColor = true;
            this.btnRelatorioPomodoro.Click += new System.EventHandler(this.btnRelatorioPomodoro_Click);
            // 
            // tmrView
            // 
            this.tmrView.Interval = 1000;
            this.tmrView.Tick += new System.EventHandler(this.tmrView_Tick);
            // 
            // cclPbrPomodoro
            // 
            this.cclPbrPomodoro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclPbrPomodoro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cclPbrPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.cclPbrPomodoro.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cclPbrPomodoro.Location = new System.Drawing.Point(129, 28);
            this.cclPbrPomodoro.Maximum = ((long)(100));
            this.cclPbrPomodoro.MinimumSize = new System.Drawing.Size(100, 100);
            this.cclPbrPomodoro.Name = "cclPbrPomodoro";
            this.cclPbrPomodoro.ProgressColor1 = System.Drawing.Color.LightCoral;
            this.cclPbrPomodoro.ProgressColor2 = System.Drawing.Color.SkyBlue;
            this.cclPbrPomodoro.ProgressShape = MyAgenda.Componentes.Pomodoro.CircularProgressBar._ProgressShape.Round;
            this.cclPbrPomodoro.Size = new System.Drawing.Size(371, 371);
            this.cclPbrPomodoro.TabIndex = 19;
            this.cclPbrPomodoro.Value = ((long)(100));
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtQuadroColor2);
            this.panel2.Controls.Add(this.txtQuadroColor1);
            this.panel2.Controls.Add(this.txtQuadroColor3);
            this.panel2.Controls.Add(this.txtQuadroColor4);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 104);
            this.panel2.TabIndex = 20;
            // 
            // panelRelogio
            // 
            this.panelRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRelogio.Controls.Add(this.lblTempo);
            this.panelRelogio.Controls.Add(this.cclPbrPomodoro);
            this.panelRelogio.Location = new System.Drawing.Point(12, 180);
            this.panelRelogio.Name = "panelRelogio";
            this.panelRelogio.Size = new System.Drawing.Size(600, 402);
            this.panelRelogio.TabIndex = 21;
            // 
            // lblTempo
            // 
            this.lblTempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTempo.Location = new System.Drawing.Point(0, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(600, 21);
            this.lblTempo.TabIndex = 20;
            this.lblTempo.Text = "00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrAlternaCor
            // 
            this.tmrAlternaCor.Enabled = true;
            this.tmrAlternaCor.Interval = 10000;
            this.tmrAlternaCor.Tick += new System.EventHandler(this.tmrAlternaCor_Tick);
            // 
            // FormPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 589);
            this.Controls.Add(this.panelRelogio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormPomodoro";
            this.Text = "Pomodoro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Pomodoro_SizeChanged);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.BarraNavegacao, 0);
            this.Controls.SetChildIndex(this.Loader, 0);
            this.Controls.SetChildIndex(this.panelRelogio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRelogio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuadroColor1;
        private System.Windows.Forms.TextBox txtQuadroColor2;
        private System.Windows.Forms.TextBox txtQuadroColor3;
        private System.Windows.Forms.TextBox txtQuadroColor4;
      //  private CircularProgressBar cclPbrPomodoro;
        private System.Windows.Forms.Timer tmrPomodoro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrView;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnRelatorioPomodoro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao_sessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaosessaoDataGridViewTextBoxColumn;
        private Componentes.Pomodoro.CircularProgressBar cclPbrPomodoro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRelogio;
        private System.Windows.Forms.Timer tmrAlternaCor;
        private System.Windows.Forms.Label lblTempo;
    }
}