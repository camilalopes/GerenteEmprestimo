using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class Destinatario
    {
        private int id;
        private string rg;
        private string nome;
        private string telefone;
        private string email;


        public Destinatario()
        {
            nome = "";
        }

        public Destinatario(string nome)
        {
            Nome = nome;
        }

        public Destinatario(int id)
        {
            SetId(id);
        }

        public Destinatario(int id, string rg, string nome, string telefone, string email)
        {
            SetId(id);
            Rg = rg;
            Nome = nome;
            Telefone = telefone;
            Email = email;

        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return nome;
        }

    }
}