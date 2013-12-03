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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            cboEmprestimos.Items.Add("Todos");
            cboEmprestimos.Items.Add("Mais recentes");
            cboEmprestimos.Items.Add("Pendentes");

            cboEmprestimos.SelectedIndex = 0;

            dgvRelatorio.DataSource = EmprestimoDao.buscarEmprestimoAux(new EmprestimoAuxiliar());


        }

        private void cboEmprestimos_Click(object sender, EventArgs e)
        {
            if (cboEmprestimos.SelectedIndex == 0)
            {
                dgvRelatorio.DataSource = EmprestimoDao.buscarEmprestimoAux(new EmprestimoAuxiliar());
            }
            if (cboEmprestimos.SelectedIndex == 2)
            {
                dgvRelatorio.DataSource = EmprestimoDao.buscarPendentes(new EmprestimoAuxiliar());
            }
        }


    }
}
