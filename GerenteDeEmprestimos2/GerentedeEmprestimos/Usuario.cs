using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class Usuario
    {
        private string login, senha, nome, telefone, email;
        private bool adm;

        public Usuario()
        { }

        public Usuario(string login, string senha, string nome, string telefone, string email, bool adm)
        {
            Login = login;
            Senha = senha;
            Telefone = telefone;
            Email = email;
            Adm = adm;
        }

        public Usuario(string login, string senha, bool adm)
        {
            Login = login;
            Senha = senha;
            Adm = adm;
        }

        public Usuario(string login,string senha)
        {
            Login = login;
            Senha = senha;
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

        public bool Adm
        {
            get { return adm; }
            set { adm = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
