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
            
            SetId(id);
        }
        
        public Item(string descricao)
        {
            Descricao = descricao;
        }

        public Item(int id, string descricao)
        {
            
            SetId(id);
            Descricao = descricao;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
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

