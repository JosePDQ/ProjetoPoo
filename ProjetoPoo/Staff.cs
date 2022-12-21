using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPoo
{
    class Staff:Pessoa
    {
        public string funcao;

        public Staff(int id, string nome, int equipa, string funcao) : base(id, nome)
        {
            this.funcao = funcao;
        }
    }
}
