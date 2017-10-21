namespace MyAgenda {
    partial class FormListaAfazeres {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.barraNavegacao1 = new MyAgenda.Componentes.BarraNavegacao();
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
            // FormListaAfazeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.barraNavegacao1);
            this.Name = "FormListaAfazeres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAgenda | Lista de Afazeres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.BarraNavegacao barraNavegacao1;
    }
}