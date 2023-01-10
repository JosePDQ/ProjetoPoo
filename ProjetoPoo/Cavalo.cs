using System;
using System.Collections.Generic;
using System.Text;

public class Cavalo : Animal
{
	public Rider rider;

    

    public Cavalo(int id,string nome, string raca, int velocidade, int stamina, bool saude, float valor,Rider rider) : base(id,nome,raca,velocidade,stamina,saude,valor)
	{
        this.id = id;
        this.nome = nome;
        this.raca = raca;
        this.velocidade = velocidade;
        this.stamina = stamina;
        this.saude = saude;
        this.valor = valor;
		this.rider = rider;
	}

    

	
}

/* Rider diogo = new Rider(1,"diogo",65);
            Pessoa pedro = new Pessoa(2,"pedro");
            Cavalo cavalo = new Cavalo("pegasus", "branco", 10, 20,true,1,10000,diogo);

            List<Pessoa> membros = new List<Pessoa> { diogo, pedro };
            Equipa equipa1 = new Equipa(1,"LAL",membros);

            Calendario calendario = new Calendario
            {
                dia = 2,
                mes = 12,
                ano = 2022,
            };

            foreach(Pessoa membro in equipa1.membros)
            {
                Console.WriteLine(membro.nome);
            }*/