using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class Emprestimo
    {
        private int id;
        private DateTime dataEmprestimo;
        private bool entregue;
        private int fkDestinatario;
        private int fkItem;

        public Emprestimo()
        {
        }

        public Emprestimo(int id, bool entregue)
        {
            Id = id;
            Entregue = entregue;
        }

        public Emprestimo(int id)
        {
            Id = id;
        }


        public Emprestimo(int id, DateTime dataEmprestimo, bool entregue, int fkDestinatario, int fkItem)
        {
            Id = id;
            DataEmprestimo = dataEmprestimo;
            Entregue = entregue;
            FkDestinatario = fkDestinatario;
            FkItem = fkItem;
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

        public int FkDestinatario
        {
            get { return fkDestinatario; }
            set { fkDestinatario = value; }
        }

        public int FkItem
        {
            get { return fkItem; }
            set { fkItem = value; }
        }

    }
}
