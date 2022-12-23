using System;
using System.Collections.Generic;
using System.Text;
using StaffSpace;

public class Rider : Pessoa
    {
        public float peso;

    

        public Rider(int id, string nome,bool trabalha,float peso) : base(id, nome,trabalha)
        {
            this.id = id;
            this.nome = nome;
            this.trabalha = trabalha;
            this.peso = peso;
        }
    }

