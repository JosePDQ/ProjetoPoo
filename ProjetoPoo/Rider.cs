using System;
using System.Collections.Generic;
using System.Text;
using StaffSpace;

public class Rider : Pessoa
    {
        public float peso;

    

        public Rider(int id, string nome,bool trabalha,float salarioDiario, float peso) : base(id, nome,trabalha, salarioDiario)
        {
            this.id = id;
            this.nome = nome;
            this.trabalha = trabalha;
            this.salarioDiario = salarioDiario;
            this.peso = peso;
        }
    }

