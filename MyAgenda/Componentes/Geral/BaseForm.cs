using MyAgenda.Controladores.Geral;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Geral
{
    public partial class BaseForm : Form
    {
        public enum EBarraNavegacaoBotoes { INICIO = 1, POMODORO, TAREFAS, MATRIZ_TEMPO, CONTATOS, SAIR }
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

            BarraNavegacao.AddItem("Sair", Properties.Resources.ic_exit_to_app_white, BarraNavegacao.EPosicao.DIREITA, OnBarraNavegacaoSairClick, (int) EBarraNavegacaoBotoes.SAIR);
            BarraNavegacao.AddItem("Contatos", Properties.Resources.ic_people_white, BarraNavegacao.EPosicao.DIREITA, OnBarraNavegacaoContatosClick, (int)EBarraNavegacaoBotoes.CONTATOS);

            BarraNavegacao.Width = this.Width;

        }

        private void OnBarraNavegacaoSairClick(Button btn, int itemId)
        {
            UsuarioController u = UsuarioController.GetInstance();
            u.EncerraSessaoDefinitivo();

            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void OnBarraNavegacaoContatosClick(Button btn, int itemId)
        {
            //Abrir form de contatos
            FormListaContatos contatos = new FormListaContatos();
            contatos.Show();
        }

        protected virtual void OnBarraNavegacaoItemClick(Button btn, int itemId){ }
        
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            FormCollection forms = Application.OpenForms;
            
            if (forms.Count == 0 || _podeFechar(forms))
            {
                UsuarioController u = UsuarioController.GetInstance();
                if (u.IsAutenticado)
                {
                    u.EncerraSessao();
                }

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
                    UsuarioController u = UsuarioController.GetInstance();
                    if (u.IsAutenticado)
                    {
                        u.EncerraSessao();
                    }

                    Application.Exit();
                }
            }
        }

        private bool _podeFechar(FormCollection forms)
        {
            bool podeFechar = true;

            foreach (Form f in forms)
            {
                Type tForm = f.GetType();

                if ((tForm != typeof(FormListaContatos) &&
                    tForm != typeof(FormChat) &&
                    tForm != typeof(Notification) &&
                    tForm != typeof(FormEditarEvento) &&
                    tForm != typeof(FormAlertaEvento) &&
                    tForm != typeof(FormEditarTarefa)) &&
                    f.Visible)
                {
                    podeFechar = false;
                }
            }

            return podeFechar;
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
            DesabilitaTudo();
        }

        public void ParaCarregar()
        {
            Loader.Active = false;
            HabilitaTudo();
        }

        public void DesabilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        public void HabilitaTudo()
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

            UsuarioController u = UsuarioController.GetInstance();
            if (u.IsAutenticado)
            {
                this.Text = u.GetModelo().Nome + " | " + this.Text;
            }
        }
        
    }
}
