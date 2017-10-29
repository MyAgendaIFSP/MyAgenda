using MyAgenda.Controladores.Geral;
using MyAgenda.Controladores.ListaContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormListaContatos : Form
    {
        private ContatoController _contatoBuscado;

        private List<ContatoController> _contatosBuscados;
        
        public FormListaContatos()
        {
            InitializeComponent();
        }

        private void btnAddContato_MouseEnter(object sender, EventArgs e)
        {
            btnAddContato.Image = Properties.Resources.ic_person_add_white_24dp;
        }

        private void btnAddContato_MouseLeave(object sender, EventArgs e)
        {
            btnAddContato.Image = Properties.Resources.ic_person_add_black_24dp;
        }

        private void Contatos_Load(object sender, EventArgs e)
        {
            //buscar os contatos
            contatoLista.CarregaLista();
        }
        
        private void btnAddContato_Click(object sender, EventArgs e)
        {
            //Adicionar o contato buscado
            _contatoBuscado = _contatosBuscados.Single(contato => cbbBuscarContato.Text.Contains(contato.GetModelo().Email));
            contatoLista.AdicionarContato(_contatoBuscado);
        }

        private void Contatos_FormClosed(object sender, FormClosedEventArgs e)
        {

            UsuarioController u = UsuarioController.GetInstance();
            if (u.IsAutenticado)
            {
                u.EncerraSessao();
            }

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

        private void timerAtualizaContatos_Tick(object sender, EventArgs e)
        {
            //Atualizar os contatos
            contatoLista.AtualizaStatus();
        }

        private void timerBuscaContato_Tick(object sender, EventArgs e)
        {
            string busca = cbbBuscarContato.Text;

            _contatosBuscados = contatoLista.BuscaContato(busca);

            cbbBuscarContato.Items.Clear();
            cbbBuscarContato.Items.AddRange(_contatosBuscados.Select(contato => contato.GetModelo().Nome + " - " + contato.GetModelo().Email).ToArray());

            cbbBuscarContato.DroppedDown = true;

            cbbBuscarContato.Text = busca;

            if (busca.Length > 0)
            {
                cbbBuscarContato.Select(busca.Length, 0);
            }

            Cursor.Current = Cursors.Default;

            timerBuscaContato.Stop();
        }

        private void cbbBuscarContato_TextUpdate(object sender, EventArgs e)
        {
            timerBuscaContato.Stop();
            timerBuscaContato.Start();
        }
    }
}
