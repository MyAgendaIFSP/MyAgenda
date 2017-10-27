﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Geral
{
    public partial class BaseForm : Form
    {

        public Label StatusLabel { get; set; }

        private bool _temBarraNavegacao = true;
        public bool TemBarraNavegacao
        {
            get
            {
                return _temBarraNavegacao;
            }

            set
            {
                _temBarraNavegacao = value;

                if (BarraNavegacao != null)
                {
                    if (_temBarraNavegacao)
                    {
                        BarraNavegacao.Visible = true;
                        Loader.Location = new Point(0, BarraNavegacao.Height);
                    }
                    else
                    {
                        BarraNavegacao.Visible = false;
                        Loader.Location = new Point(0, 0);
                    }
                }
            }
        }

        public BaseForm()
        {
            InitializeComponent();

            BarraNavegacao.MenuItemClick += OnBarraNavegacaoItemClick;

            BarraNavegacao.AddItem("Sair", Properties.Resources.ic_exit_to_app_white, BarraNavegacao.EPosicao.DIREITA, OnBarraNavegacaoSairClick, 4);
            BarraNavegacao.AddItem("Offline", Properties.Resources.ic_cloud_queue_white, BarraNavegacao.EPosicao.DIREITA, OnBarraNavegacaoCloudClick, 5);

            BarraNavegacao.Width = this.Width;

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void OnBarraNavegacaoSairClick(Button btn, int itemId)
        {
            Application.Exit();
        }

        protected virtual void OnBarraNavegacaoItemClick(Button btn, int itemId){ }

        protected virtual void OnBarraNavegacaoCloudClick(Button btn, int itemId)
        {
            MessageBox.Show("botão Nuvem");

            //Realizar aqui a sincronização dos dados do usuário

            btn.Image = Properties.Resources.ic_cloud_white;
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            if (forms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                bool quit = true;

                foreach (Form f in forms)
                {
                    quit = !(f.Visible == true);
                }

                if (quit)
                {
                    Application.Exit();
                }
            }
        }

        public void MostraErro(string msg)
        {
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Text = msg;
            StatusLabel.Visible = true;
        }

        public void MostraSucesso(string msg)
        {
            StatusLabel.ForeColor = Color.LimeGreen;
            StatusLabel.Text = msg;
            StatusLabel.Visible = true;
        }

        public void ComecaCarregar()
        {
            Loader.Active = true;
            _desabilitaTudo();
        }

        public void ParaCarregar()
        {
            Loader.Active = false;
            _habilitaTudo();
        }

        private void _desabilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        private void _habilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            BarraNavegacao.Width = this.Width;
            BarraNavegacao.Invalidate();

            if (this.WindowState == FormWindowState.Normal)
            {
                Size tamTela = Screen.PrimaryScreen.WorkingArea.Size;

                this.Location = new Point((tamTela.Width / 2) - (this.Width / 2), (tamTela.Height / 2) - (this.Height / 2));
            }
        }
    }
}
