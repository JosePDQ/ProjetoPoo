using System;
using System.Collections.Generic;
using System.Text;

namespace StaffSpace {
    public enum Funcao
    {
        Veterinario,
        CEO,
        Treinador
    }
    public class Staff : Pessoa
    {
       public Funcao funcao { get; set; }
    
        public Staff(int id, string nome, bool trabalha,Funcao Funcao) : base(id, nome,trabalha)
        {
            this.id = id;
            this.nome = nome;

            this.funcao = Funcao;
        }
    }
}

