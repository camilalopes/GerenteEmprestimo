using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidade
{
    class EmprestimoAuxiliar
    {
        private int id;
        private DateTime dataEmprestimo;
        private bool entregue;
        private string destinatario;
        private string item;

        public EmprestimoAuxiliar()
        { 
        }

        public EmprestimoAuxiliar(int id, bool entregue)
        {
            Id = id;
            Entregue = entregue;
        }

        public EmprestimoAuxiliar(int id)
        {
            Id = id;
        }

        public EmprestimoAuxiliar(int id, DateTime dataEmprestimo, bool entregue, string destinatario, string item)
        {
            Id = id;
            DataEmprestimo = dataEmprestimo;
            Entregue = entregue;
            Destinatario = destinatario;
            Item = item;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }

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

