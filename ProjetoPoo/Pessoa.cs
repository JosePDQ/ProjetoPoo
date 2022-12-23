using System;
using System.Collections.Generic;
using System.Text;
using StaffSpace;


public class Pessoa
    {
        public int id;
        public string nome;
        public bool trabalha;
        public Pessoa(int id, string nome,bool trabalha)
        {
            this.id = id;
            this.nome = nome;
            this.trabalha = trabalha;
        }
    }
