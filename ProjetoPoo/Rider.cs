using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPoo
{
    class Rider : Pessoa
    {
        public float peso;
        public Rider(int id, string nome, int equipa,float peso) : base(id, nome, equipa)
        {
            this.peso = peso;
        }
    }
}
