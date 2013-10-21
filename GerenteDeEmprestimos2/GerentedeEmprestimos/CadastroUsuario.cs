using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;
using Dao;

namespace GerentedeEmprestimos
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                UsuarioDao.salvarUsuario(new Usuario(txtLogin.Text, txtSenha.Text, txtNome.Text,
                     txtTelefone.Text, txtTelefone.Text, false));


                
                Restaurar();
            }
            else
            {
                UsuarioDao.salvarUsuario(new Usuario(txtLogin.Text, txtSenha.Text, txtNome.Text,
                    txtTelefone.Text, txtTelefone.Text, true));

                Restaurar();
            }


        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Padrão");
            cboTipo.Items.Add("Administrador");
            cboTipo.SelectedIndex = 0;
        }

        private void Restaurar()
        {
            txtTelefone.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
        }
    }
}
