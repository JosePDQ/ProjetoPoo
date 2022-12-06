using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPoo
{
    class Pessoa
    {
        public int id;
        public string nome;
        public int equipa;

        public Pessoa(int id, string nome, int equipa)
        {
            this.id = id;
            this.nome = nome;
            this.equipa = equipa;
        }
    }
}
