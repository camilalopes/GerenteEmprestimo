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
using System.Collections;

namespace GerentedeEmprestimos
{
    public partial class FormItem : Form
    {
        private Button btExcluir;
        private Button btAlterar;
        private Button btCadastrar;
        private Label lbNome;
        private TextBox txtNomeItem;
        private DataGridView dgvItem;

        private FormPrincipal fp;

        public int id_item;

        public FormItem(FormPrincipal fp)
        {
            InitializeComponent();

            this.fp = fp;
        }
        

        public FormItem()
        {
            InitializeComponent();
        }
    
        private void InitializeComponent()
        {
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(12, 12);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(294, 237);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(195, 305);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(108, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAlterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(164, 334);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(139, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Salvar Mudanças";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(195, 276);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(108, 23);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(9, 260);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(46, 16);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(12, 279);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(130, 22);
            this.txtNomeItem.TabIndex = 6;
            this.txtNomeItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomeItem_KeyUp);
            // 
            // FormItem
            // 
            this.ClientSize = new System.Drawing.Size(318, 358);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.dgvItem);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens";
            this.Load += new System.EventHandler(this.FormItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            dgvItem.DataSource = ItemDao.buscarItem(new Item());

        }
        public void Restaurar()
        {
            txtNomeItem.Text = "";
        }
        

        /// <summary>
        /// Gera um objeto do tipo item e grava o mesmo no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeItem.Text.Trim() == "")
            {
                MessageBox.Show("Informe o campo de descrição do Item !");
            }
            else
            {
                Item item = new Item(0, txtNomeItem.Text);
                ItemDao.salvarItem(item);
                Restaurar();
                dgvItem.DataSource = ItemDao.buscarItem(new Item());

            }
        }

        private void txtNomeItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtNomeItem.Text.Trim() == "")
                {
                    MessageBox.Show("Informe o campo de descrição do Item !");
                }
                else
                {
                    Item item = new Item(0, txtNomeItem.Text);
                    ItemDao.salvarItem(item);
                    Restaurar();
                    dgvItem.DataSource = ItemDao.buscarItem(new Item());

                }

                

 
            }




        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Recupera a fonte de dados como (as) ArrayList.
                ArrayList items
                    = dgvItem.DataSource as ArrayList;

                Item itemClicado = (Item)items[e.RowIndex];

                id_item = itemClicado.Id;
            
                fp.preencherTxtNome((String)ItemDao.buscarPorId(new Item(id_item)).Descricao);

                fp.id_item = id_item;


            }

        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ArrayList items
                     = dgvItem.DataSource as ArrayList;

                Item itemClicado = (Item)items[e.RowIndex];
                id_item = itemClicado.Id;

                Item item = ItemDao.buscarPorId(new Item(id_item));

                txtNomeItem.Text = item.Descricao;

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            ItemDao.salvarItem(new Item(id_item,txtNomeItem.Text));

            dgvItem.DataSource = ItemDao.buscarItem(new Item());

            Restaurar();
        }
    }
}
