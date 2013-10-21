using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class Item
    {
        private int id;
        private string descricao;

       
        public Item()
        {
            descricao = "";
        }

      
        public Item(int id)
        {
            Id = id;
        }
        
        public Item(string descricao)
        {
            Descricao = descricao;
        }

        public Item(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public override string ToString()
        {
            return descricao;

        }
    }
}

