using System;
using System.Collections;
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
    public partial class FormPrincipal : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem visualizrToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private Label lbDestinatario;
        private TextBox txtDestinatario;
        private Label lbItem;
        private Button btEmprestar;
        private Label lbOpcaoFiltro;
        private Button btFiltrar;
        private ComboBox comboFiltros;
        private CheckBox checkEntregue;
        private Label labelEntregue;
        private TextBox txtItem;
        private DataGridView dgvFeed;
        private ListBox listaItems;
        private ListBox listaDestinatarios;
        private ToolStripMenuItem USUÁRIOToolStripMenuItem;
        private ToolStripMenuItem cadToolStripMenuItem;
        private ToolStripMenuItem destinatToolStripMenuItem;
        private Button btSalvarAlteracoes;


        public int id_emprestimo;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem rELATÓRIOToolStripMenuItem;
        private ToolStripMenuItem empréstimosToolStripMenuItem;
        public bool admAux;

        public bool AdmAux
        {
            get { return admAux; }
            set { admAux = value; }
        }


        public FormPrincipal()
        {
            InitializeComponent();
           

        }
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.USUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.btEmprestar = new System.Windows.Forms.Button();
            this.lbOpcaoFiltro = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.comboFiltros = new System.Windows.Forms.ComboBox();
            this.checkEntregue = new System.Windows.Forms.CheckBox();
            this.labelEntregue = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dgvFeed = new System.Windows.Forms.DataGridView();
            this.listaItems = new System.Windows.Forms.ListBox();
            this.listaDestinatarios = new System.Windows.Forms.ListBox();
            this.btSalvarAlteracoes = new System.Windows.Forms.Button();
            this.rELATÓRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.destinatToolStripMenuItem,
            this.USUÁRIOToolStripMenuItem,
            this.lOGOUTToolStripMenuItem,
            this.rELATÓRIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizrToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.itemToolStripMenuItem.Text = "ITEM";
            // 
            // visualizrToolStripMenuItem
            // 
            this.visualizrToolStripMenuItem.Name = "visualizrToolStripMenuItem";
            this.visualizrToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.visualizrToolStripMenuItem.Text = "Visualizar";
            this.visualizrToolStripMenuItem.Click += new System.EventHandler(this.visualizrToolStripMenuItem_Click);
            // 
            // destinatToolStripMenuItem
            // 
            this.destinatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            this.destinatToolStripMenuItem.Name = "destinatToolStripMenuItem";
            this.destinatToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.destinatToolStripMenuItem.Text = "DESTINATÁRIO";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // USUÁRIOToolStripMenuItem
            // 
            this.USUÁRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadToolStripMenuItem});
            this.USUÁRIOToolStripMenuItem.Name = "USUÁRIOToolStripMenuItem";
            this.USUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.USUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // cadToolStripMenuItem
            // 
            this.cadToolStripMenuItem.Name = "cadToolStripMenuItem";
            this.cadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cadToolStripMenuItem.Text = "Cadastrar";
            this.cadToolStripMenuItem.Click += new System.EventHandler(this.cadToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbDestinatario
            // 
            this.lbDestinatario.AutoSize = true;
            this.lbDestinatario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatario.Location = new System.Drawing.Point(12, 39);
            this.lbDestinatario.Name = "lbDestinatario";
            this.lbDestinatario.Size = new System.Drawing.Size(85, 16);
            this.lbDestinatario.TabIndex = 1;
            this.lbDestinatario.Text = "Destinatário: ";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestinatario.Location = new System.Drawing.Point(15, 58);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(215, 22);
            this.txtDestinatario.TabIndex = 2;
            this.txtDestinatario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDestinatario_KeyUp);
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(12, 151);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(41, 16);
            this.lbItem.TabIndex = 3;
            this.lbItem.Text = "Item: ";
            // 
            // btEmprestar
            // 
            this.btEmprestar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmprestar.Location = new System.Drawing.Point(119, 283);
            this.btEmprestar.Name = "btEmprestar";
            this.btEmprestar.Size = new System.Drawing.Size(111, 23);
            this.btEmprestar.TabIndex = 7;
            this.btEmprestar.Text = "Concluído";
            this.btEmprestar.UseVisualStyleBackColor = true;
            this.btEmprestar.Click += new System.EventHandler(this.btEmprestar_Click);
            // 
            // lbOpcaoFiltro
            // 
            this.lbOpcaoFiltro.AutoSize = true;
            this.lbOpcaoFiltro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcaoFiltro.Location = new System.Drawing.Point(259, 36);
            this.lbOpcaoFiltro.Name = "lbOpcaoFiltro";
            this.lbOpcaoFiltro.Size = new System.Drawing.Size(118, 16);
            this.lbOpcaoFiltro.TabIndex = 27;
            this.lbOpcaoFiltro.Text = "Opções de busca: ";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltrar.Location = new System.Drawing.Point(637, 55);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(119, 25);
            this.btFiltrar.TabIndex = 26;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // comboFiltros
            // 
            this.comboFiltros.FormattingEnabled = true;
            this.comboFiltros.Location = new System.Drawing.Point(262, 55);
            this.comboFiltros.Name = "comboFiltros";
            this.comboFiltros.Size = new System.Drawing.Size(309, 24);
            this.comboFiltros.TabIndex = 25;
            // 
            // checkEntregue
            // 
            this.checkEntregue.AutoSize = true;
            this.checkEntregue.Location = new System.Drawing.Point(29, 286);
            this.checkEntregue.Name = "checkEntregue";
            this.checkEntregue.Size = new System.Drawing.Size(44, 20);
            this.checkEntregue.TabIndex = 29;
            this.checkEntregue.Text = "Ok";
            this.checkEntregue.UseVisualStyleBackColor = true;
            // 
            // labelEntregue
            // 
            this.labelEntregue.AutoSize = true;
            this.labelEntregue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntregue.Location = new System.Drawing.Point(12, 267);
            this.labelEntregue.Name = "labelEntregue";
            this.labelEntregue.Size = new System.Drawing.Size(61, 16);
            this.labelEntregue.TabIndex = 28;
            this.labelEntregue.Text = "Entrege: ";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 170);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(218, 22);
            this.txtItem.TabIndex = 30;
            this.txtItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyUp);
            // 
            // dgvFeed
            // 
            this.dgvFeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeed.Location = new System.Drawing.Point(262, 99);
            this.dgvFeed.Name = "dgvFeed";
            this.dgvFeed.Size = new System.Drawing.Size(494, 247);
            this.dgvFeed.TabIndex = 31;
            this.dgvFeed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeed_CellClick);
            // 
            // listaItems
            // 
            this.listaItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaItems.FormattingEnabled = true;
            this.listaItems.ItemHeight = 16;
            this.listaItems.Location = new System.Drawing.Point(12, 187);
            this.listaItems.Name = "listaItems";
            this.listaItems.Size = new System.Drawing.Size(218, 66);
            this.listaItems.TabIndex = 32;
            this.listaItems.Visible = false;
            this.listaItems.Click += new System.EventHandler(this.listaItems_Click);
            // 
            // listaDestinatarios
            // 
            this.listaDestinatarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDestinatarios.FormattingEnabled = true;
            this.listaDestinatarios.ItemHeight = 16;
            this.listaDestinatarios.Location = new System.Drawing.Point(15, 77);
            this.listaDestinatarios.Name = "listaDestinatarios";
            this.listaDestinatarios.Size = new System.Drawing.Size(215, 66);
            this.listaDestinatarios.TabIndex = 33;
            this.listaDestinatarios.Visible = false;
            this.listaDestinatarios.Click += new System.EventHandler(this.listaDestinatarios_Click);
            // 
            // btSalvarAlteracoes
            // 
            this.btSalvarAlteracoes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarAlteracoes.Location = new System.Drawing.Point(87, 319);
            this.btSalvarAlteracoes.Name = "btSalvarAlteracoes";
            this.btSalvarAlteracoes.Size = new System.Drawing.Size(143, 23);
            this.btSalvarAlteracoes.TabIndex = 34;
            this.btSalvarAlteracoes.Text = "Salvar Alterações";
            this.btSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btSalvarAlteracoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // rELATÓRIOToolStripMenuItem
            // 
            this.rELATÓRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empréstimosToolStripMenuItem});
            this.rELATÓRIOToolStripMenuItem.Name = "rELATÓRIOToolStripMenuItem";
            this.rELATÓRIOToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.rELATÓRIOToolStripMenuItem.Text = "RELATÓRIO";
            // 
            // empréstimosToolStripMenuItem
            // 
            this.empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
            this.empréstimosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.empréstimosToolStripMenuItem.Text = "Empréstimos";
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(768, 354);
            this.Controls.Add(this.btSalvarAlteracoes);
            this.Controls.Add(this.listaDestinatarios);
            this.Controls.Add(this.listaItems);
            this.Controls.Add(this.dgvFeed);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.checkEntregue);
            this.Controls.Add(this.labelEntregue);
            this.Controls.Add(this.lbOpcaoFiltro);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.comboFiltros);
            this.Controls.Add(this.btEmprestar);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lbDestinatario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente de Empréstimos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
 
            if (admAux == false)
            {
                USUÁRIOToolStripMenuItem.Enabled = false;
            }
        
            checkEntregue.Enabled = false;
            btSalvarAlteracoes.Enabled = false;
            dgvFeed.DataSource = EmprestimoDao.buscarEmprestimoAux(new EmprestimoAuxiliar());

            if (EmprestimoDao.buscarEmprestimo(new Emprestimo()) != null)
            {
                dgvFeed.Columns[0].Width = 115;
                dgvFeed.Columns[1].Width = 65;
                dgvFeed.Columns[2].Width = 150;
                dgvFeed.Columns[3].Width = 121;
            }


                             
            comboFiltros.Items.Add("Todos");
            comboFiltros.Items.Add("Pendentes");
            comboFiltros.SelectedIndex = 0;
           

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDestinatario fd = new FormDestinatario();
            fd.Show();
        }

        private void btProcucarDestinatario_Click(object sender, EventArgs e)
        {
            
            new FormDestinatario(this).Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void btProcurarItem_Click(object sender, EventArgs e)
        {
            new FormItem(this).Show();
        }

        private void visualizrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItem fi = new FormItem();
            fi.Show();
        }

        private void btEmprestar_Click(object sender, EventArgs e)
        {
            
            DateTime data = DateTime.Now;

            Emprestimo emprestimo = new Emprestimo(0, data, checkEntregue.Checked, id_destinatario, id_item);

            EmprestimoDao.salvarEmprestimo(emprestimo);

            dgvFeed.DataSource = EmprestimoDao.buscarEmprestimoAux(new EmprestimoAuxiliar());

            Restaurar();
        }


        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        

        }

        public void preencherTxtNome(String nome)
        {
            txtItem.Text = nome;
        }
        public void preencherTxtNomeDestinatario(String nome)
        {
            txtDestinatario.Text = nome;
        }

        public void Restaurar()
        {
            txtDestinatario.Text = "";
            txtItem.Text = "";
            listaDestinatarios.Visible = false;
            listaItems.Visible = false;
        }

        public int id_destinatario { get; set; }

        public int id_item { get; set; }

        private void txtItem_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtItem.Text != "")
            {
                
                listaItems.Visible = true;
                listaItems.DataSource = ItemDao.buscarItem(new Item(txtItem.Text));

            }
            else
                listaItems.Visible = false;
                             
        }

        private void listaItems_Click(object sender, EventArgs e)
        {
            Item itemAux = ItemDao.buscarPorDescricao(new Item(listaItems.SelectedItem.ToString()));
            id_item = itemAux.GetId();
            txtItem.Text = listaItems.SelectedItem.ToString();
            listaItems.Visible = false;

        }

        private void txtDestinatario_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDestinatario.Text != "")
            {
                listaDestinatarios.Visible = true;
                listaDestinatarios.DataSource = DestinatarioDao.buscarDestinatario(new Destinatario(txtDestinatario.Text));
            }
            else
                listaDestinatarios.Visible = false;

        }

        private void listaDestinatarios_Click(object sender, EventArgs e)
        {
            Destinatario destinatarioAux = DestinatarioDao.buscarPorDescricao(new Destinatario(listaDestinatarios.SelectedItem.ToString()));
            id_destinatario = destinatarioAux.GetId();
            txtDestinatario.Text = listaDestinatarios.SelectedItem.ToString();
            listaDestinatarios.Visible = false;

        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario c = new CadastroUsuario();
            c.Show();
        }

        

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (comboFiltros.SelectedItem == "Pendentes")
            {
                dgvFeed.DataSource = EmprestimoDao.buscarPendentes(new Emprestimo());
            }
            else
                dgvFeed.DataSource = EmprestimoDao.buscarEmprestimo(new Emprestimo());
        }

        private void dgvFeed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            checkEntregue.Enabled = true;
            btEmprestar.Enabled = false;
            btSalvarAlteracoes.Enabled = true;
            if (e.RowIndex != -1)
            {
                ArrayList emprestimosAux
                         = dgvFeed.DataSource as ArrayList;

                EmprestimoAuxiliar emprestimoAuxClicado = (EmprestimoAuxiliar)emprestimosAux[e.RowIndex];

                id_emprestimo = emprestimoAuxClicado.GetId();

                Emprestimo emprestimo = EmprestimoDao.buscarPorId(new Emprestimo(id_emprestimo));


                txtDestinatario.Text = DestinatarioDao.buscarPorId(new Destinatario(emprestimo.FkDestinatario)).Nome;
                txtItem.Text = ItemDao.buscarPorId(new Item(emprestimo.FkItem)).Descricao;
                checkEntregue.Checked = emprestimo.Entregue;


                /* ArrayList emprestimosAux
                      = dgvFeed.DataSource as ArrayList;

                 EmprestimoAuxiliar emprestimoClicado = (EmprestimoAuxiliar)emprestimosAux[e.RowIndex];
                 id_emprestimo = emprestimoClicado.GetId();

                 EmprestimoAuxiliar emprestimoAux = EmprestimoAuxiliarDao.buscarPorId(new EmprestimoAuxiliar(id_emprestimo));

                
                 txtDestinatario.Text = emprestimoAux.Destinatario;
                 txtItem.Text = emprestimoAux.Item;
                 checkEntregue.Checked = emprestimoAux.Entregue;*/

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           EmprestimoDao.salvarEmprestimo(new Emprestimo(id_emprestimo, checkEntregue.Checked));
           dgvFeed.DataSource = EmprestimoDao.buscarEmprestimoAux(new EmprestimoAuxiliar());

            btEmprestar.Enabled = true;
            Restaurar();
            btSalvarAlteracoes.Enabled = false;
            
            checkEntregue.Enabled = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Não está funcionando ainda..

        }

    }
}
