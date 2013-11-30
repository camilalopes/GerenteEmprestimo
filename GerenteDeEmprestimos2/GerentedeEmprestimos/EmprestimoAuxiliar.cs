using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidade
{
    class EmprestimoAuxiliar
    {

        private DateTime dataEmprestimo;
        private bool entregue;
        private string destinatario;
        private string item;
        private int id;

        public EmprestimoAuxiliar()
        {
            destinatario = "";
        }

        public EmprestimoAuxiliar(bool entregue)
        {
            Entregue = entregue;
        }

        public EmprestimoAuxiliar(int id, string destinatario, DateTime dataEmprestimo, bool entregue, string item)
        {
            SetId(id);
            Destinatario = destinatario;
            DataEmprestimo = dataEmprestimo;
            Entregue = entregue;
            Item = item;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }

        public bool Entregue
        {
            get { return entregue; }
            set { entregue = value; }
        }

        public string Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; }
        }

        public string Item
        {
            get { return item; }
            set { item = value; }
        }


    }
}

