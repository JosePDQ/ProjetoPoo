using System;
using System.Collections.Generic;
using System.Text;


    public class Rider : Pessoa
    {
        public float peso;
        public Rider(int id, string nome,float peso) : base(id, nome)
        {
            this.peso = peso;
        }
    }

