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
using System.Collections;

namespace GerentedeEmprestimos
{
    public partial class FormDestinatario : Form
    {
        private TextBox txtNome;
        private Label lbNome;
        private Button btCadastrar;
        private Button btAlterar;
        private Button btExcluir;
        private Label lbTelefone;
        private Label lbEmail;
        private TextBox txtRg;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private DataGridView dgvDestinatario;

        private FormPrincipal fp;
        private Label lbRg;
        private Button btPesquisar;

        private int id_destinatario;


        public FormDestinatario(FormPrincipal fp)
        {
            InitializeComponent();

            this.fp = fp;
        }

        public FormDestinatario()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.dgvDestinatario = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinatario
            // 
            this.dgvDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDestinatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatario.Location = new System.Drawing.Point(15, 12);
            this.dgvDestinatario.Name = "dgvDestinatario";
            this.dgvDestinatario.Size = new System.Drawing.Size(537, 222);
            this.dgvDestinatario.TabIndex = 0;
            this.dgvDestinatario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinatario_CellClick);
            this.dgvDestinatario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinatario_CellDoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(200, 273);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 252);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(46, 16);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(444, 281);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(108, 23);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAlterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(423, 333);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(139, 23);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "Salvar Mudanças";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(444, 308);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(108, 23);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(197, 308);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(60, 15);
            this.lbTelefone.TabIndex = 7;
            this.lbTelefone.Text = "Telefone: ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(198, 252);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 15);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email: ";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(12, 327);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(153, 21);
            this.txtRg.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(201, 327);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(155, 21);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 21);
            this.txtEmail.TabIndex = 11;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Location = new System.Drawing.Point(12, 307);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(35, 16);
            this.lbRg.TabIndex = 12;
            this.lbRg.Text = "RG: ";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(444, 252);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(108, 23);
            this.btPesquisar.TabIndex = 13;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormDestinatario
            // 
            this.ClientSize = new System.Drawing.Size(574, 360);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvDestinatario);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDestinatario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destinatários";
            this.Load += new System.EventHandler(this.FormDestinatario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Restaurar()
        {


            txtNome.Text = null;
            txtNome.Focus();
            txtRg.Text = null;
            txtTelefone.Text = null;
            txtEmail.Text = null;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormDestinatario_Load(object sender, EventArgs e)
        {
            dgvDestinatario.DataSource = DestinatarioDao.buscarDestinatario(new Destinatario());
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" && txtEmail.Text.Trim() == "" && txtTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Informe os campos necessarioas para o cadastro !");
            }
            else
            {
                Destinatario destinatario = new Destinatario(0,txtRg.Text, txtNome.Text, txtTelefone.Text, txtEmail.Text);
                DestinatarioDao.salvarDestinatario(destinatario);
                Restaurar();
                dgvDestinatario.DataSource = DestinatarioDao.buscarDestinatario(new Destinatario());


            }

        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

            }
        }

        private void dgvDestinatario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Recupera a fonte de dados como (as) ArrayList.
                ArrayList destinatarios
                    = dgvDestinatario.DataSource as ArrayList;

                Destinatario destinatarioClicado = (Destinatario)destinatarios[e.RowIndex];
                id_destinatario = destinatarioClicado.GetId();
               
                Destinatario destinatario = DestinatarioDao.buscarPorId(new Destinatario(id_destinatario));

                fp.preencherTxtNomeDestinatario(destinatario.Nome);
                fp.id_destinatario = id_destinatario;
               
                
            }
        }

        private void dgvDestinatario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ArrayList destinatarios
                     = dgvDestinatario.DataSource as ArrayList;

                Destinatario destinatarioClicado = (Destinatario)destinatarios[e.RowIndex];
                id_destinatario = destinatarioClicado.GetId();

                Destinatario destinatario = DestinatarioDao.buscarPorId(new Destinatario(id_destinatario));

                txtNome.Text = destinatario.Nome;
                txtRg.Text = destinatario.Rg.ToString();
                txtEmail.Text = destinatario.Email;
                txtTelefone.Text = destinatario.Telefone;

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            DestinatarioDao.salvarDestinatario(new Destinatario(id_destinatario, txtRg.Text, txtNome.Text, txtTelefone.Text, txtEmail.Text));

            dgvDestinatario.DataSource = DestinatarioDao.buscarDestinatario(new Destinatario());

            Restaurar();
        }

    }
}
