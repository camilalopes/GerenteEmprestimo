using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Entidade;

namespace GerentedeEmprestimos
{
    public partial class FormUsuario : Form
    {
       private FormPrincipal fp;


        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {

            Usuario resposta = UsuarioDao.buscarUsuario(new Usuario(txtLogin.Text, txtSenha.Text));         

            if (resposta != null)
            {
                fp = new FormPrincipal();
                fp.AdmAux = resposta.Adm;
                fp.Show();
               

            }
            else
                MessageBox.Show("Este usuario não existe");

            

        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Usuario resposta = UsuarioDao.buscarUsuario(new Usuario(txtLogin.Text, txtSenha.Text));


                if (resposta != null)
                {

                    fp = new FormPrincipal();
                    fp.AdmAux = resposta.Adm;
                    fp.Show();
                    
                }
                else
                    MessageBox.Show("Este usuario não existe");
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }


    }
}
