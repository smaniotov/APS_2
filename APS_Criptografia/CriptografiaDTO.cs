using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Criptografia
{
    public class CurrentUser
    {
        public int acesso
        {
            get
            {
                return this.acesso;
            }
            set
            {
                this.acesso = value;
            }
        }

        public String nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public CurrentUser(int acesso, String nome)
        {
            this.acesso = acesso;
            this.nome = nome;
        }
    }
}
