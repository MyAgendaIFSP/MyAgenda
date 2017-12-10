namespace MyAgenda
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.txtQuadroColor1 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor2 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor3 = new System.Windows.Forms.TextBox();
            this.txtQuadroColor4 = new System.Windows.Forms.TextBox();
            this.tmrPomodoro = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao_sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwpomodoroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwpomodoroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pomodoroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudTempoLong = new System.Windows.Forms.NumericUpDown();
            this.nudTempoShort = new System.Windows.Forms.NumericUpDown();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.btnRelatorioPomodoro = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpomodoroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpomodoroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoShort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuadroColor1
            // 
            this.txtQuadroColor1.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuadroColor1.Enabled = false;
            this.txtQuadroColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuadroColor1.Location = new System.Drawing.Point(33, 26);
            this.txtQuadroColor1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor1.Multiline = true;
            this.txtQuadroColor1.Name = "txtQuadroColor1";
            this.txtQuadroColor1.ReadOnly = true;
            this.txtQuadroColor1.Size = new System.Drawing.Size(110, 98);
            this.txtQuadroColor1.TabIndex = 3;
            // 
            // txtQuadroColor2
            // 
            this.txtQuadroColor2.Enabled = false;
            this.txtQuadroColor2.Location = new System.Drawing.Point(168, 25);
            this.txtQuadroColor2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor2.Multiline = true;
            this.txtQuadroColor2.Name = "txtQuadroColor2";
            this.txtQuadroColor2.ReadOnly = true;
            this.txtQuadroColor2.Size = new System.Drawing.Size(110, 98);
            this.txtQuadroColor2.TabIndex = 4;
            // 
            // txtQuadroColor3
            // 
            this.txtQuadroColor3.Enabled = false;
            this.txtQuadroColor3.Location = new System.Drawing.Point(313, 25);
            this.txtQuadroColor3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor3.Multiline = true;
            this.txtQuadroColor3.Name = "txtQuadroColor3";
            this.txtQuadroColor3.ReadOnly = true;
            this.txtQuadroColor3.Size = new System.Drawing.Size(110, 98);
            this.txtQuadroColor3.TabIndex = 5;
            // 
            // txtQuadroColor4
            // 
            this.txtQuadroColor4.Enabled = false;
            this.txtQuadroColor4.Location = new System.Drawing.Point(455, 25);
            this.txtQuadroColor4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQuadroColor4.Multiline = true;
            this.txtQuadroColor4.Name = "txtQuadroColor4";
            this.txtQuadroColor4.ReadOnly = true;
            this.txtQuadroColor4.Size = new System.Drawing.Size(110, 98);
            this.txtQuadroColor4.TabIndex = 6;
            // 
            // tmrPomodoro
            // 
            this.tmrPomodoro.Interval = 60000;
            this.tmrPomodoro.Tick += new System.EventHandler(this.tmrPomodoro_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(428, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sessões";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.duracao_sessao});
            this.dataGridView1.DataSource = this.vwpomodoroBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 235);
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
            // vwpomodoroBindingSource
            // 
            this.vwpomodoroBindingSource.DataMember = "vw_pomodoro";
            // 
            // pomodoroBindingSource
            // 
            this.pomodoroBindingSource.DataMember = "pomodoro";
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPausar.BackColor = System.Drawing.Color.SlateGray;
            this.btnPausar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.Color.White;
            this.btnPausar.Location = new System.Drawing.Point(187, 411);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(142, 52);
            this.btnPausar.TabIndex = 7;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciar.BackColor = System.Drawing.Color.SlateGray;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(46, 411);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 52);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.SlateGray;
            this.btnPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnPomodoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomodoro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnPomodoro.Location = new System.Drawing.Point(43, 26);
            this.btnPomodoro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(142, 58);
            this.btnPomodoro.TabIndex = 9;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.BackColor = System.Drawing.Color.SlateGray;
            this.btnShortBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnShortBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortBreak.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortBreak.ForeColor = System.Drawing.Color.White;
            this.btnShortBreak.Location = new System.Drawing.Point(184, 26);
            this.btnShortBreak.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(142, 58);
            this.btnShortBreak.TabIndex = 10;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = false;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.BackColor = System.Drawing.Color.SlateGray;
            this.btnLongBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnLongBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLongBreak.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongBreak.ForeColor = System.Drawing.Color.White;
            this.btnLongBreak.Location = new System.Drawing.Point(323, 26);
            this.btnLongBreak.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(142, 58);
            this.btnLongBreak.TabIndex = 11;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = false;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetar.BackColor = System.Drawing.Color.SlateGray;
            this.btnResetar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnResetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar.ForeColor = System.Drawing.Color.White;
            this.btnResetar.Location = new System.Drawing.Point(326, 411);
            this.btnResetar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(142, 52);
            this.btnResetar.TabIndex = 12;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // nudTempo
            // 
            this.nudTempo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudTempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTempo.Location = new System.Drawing.Point(46, 560);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(420, 27);
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
            this.panel1.Controls.Add(this.nudTempoLong);
            this.panel1.Controls.Add(this.nudTempoShort);
            this.panel1.Controls.Add(this.nudTempo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnResetar);
            this.panel1.Controls.Add(this.btnPausar);
            this.panel1.Controls.Add(this.btnLongBreak);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.btnShortBreak);
            this.panel1.Controls.Add(this.btnPomodoro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(850, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 635);
            this.panel1.TabIndex = 17;
            // 
            // nudTempoLong
            // 
            this.nudTempoLong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudTempoLong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTempoLong.Location = new System.Drawing.Point(46, 560);
            this.nudTempoLong.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudTempoLong.Name = "nudTempoLong";
            this.nudTempoLong.Size = new System.Drawing.Size(420, 27);
            this.nudTempoLong.TabIndex = 17;
            this.nudTempoLong.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTempoLong.Visible = false;
            this.nudTempoLong.ValueChanged += new System.EventHandler(this.nudTempoLong_ValueChanged);
            // 
            // nudTempoShort
            // 
            this.nudTempoShort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudTempoShort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTempoShort.Location = new System.Drawing.Point(46, 560);
            this.nudTempoShort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudTempoShort.Name = "nudTempoShort";
            this.nudTempoShort.Size = new System.Drawing.Size(420, 27);
            this.nudTempoShort.TabIndex = 16;
            this.nudTempoShort.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTempoShort.Visible = false;
            this.nudTempoShort.ValueChanged += new System.EventHandler(this.nudTempoShort_ValueChanged);
            // 
            // btnRelatorioPomodoro
            // 
            this.btnRelatorioPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioPomodoro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRelatorioPomodoro.Location = new System.Drawing.Point(697, 25);
            this.btnRelatorioPomodoro.Name = "btnRelatorioPomodoro";
            this.btnRelatorioPomodoro.Size = new System.Drawing.Size(120, 39);
            this.btnRelatorioPomodoro.TabIndex = 18;
            this.btnRelatorioPomodoro.Text = "Ranking Pomodoro";
            this.btnRelatorioPomodoro.UseVisualStyleBackColor = true;
            this.btnRelatorioPomodoro.Click += new System.EventHandler(this.btnRelatorioPomodoro_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 635);
            this.Controls.Add(this.btnRelatorioPomodoro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuadroColor4);
            this.Controls.Add(this.txtQuadroColor3);
            this.Controls.Add(this.txtQuadroColor2);
            this.Controls.Add(this.txtQuadroColor1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            this.SizeChanged += new System.EventHandler(this.Pomodoro_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpomodoroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpomodoroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoShort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuadroColor1;
        private System.Windows.Forms.TextBox txtQuadroColor2;
        private System.Windows.Forms.TextBox txtQuadroColor3;
        private System.Windows.Forms.TextBox txtQuadroColor4;
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
        private System.Windows.Forms.NumericUpDown nudTempoShort;
        private System.Windows.Forms.NumericUpDown nudTempoLong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pomodoroBindingSource;
        public System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnRelatorioPomodoro;
        private System.Windows.Forms.BindingSource vwpomodoroBindingSource;
        private System.Windows.Forms.BindingSource vwpomodoroBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao_sessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaosessaoDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}