using System;
using System.Collections.Generic;
using System.Text;

public class Cavalo : Animal
{
	public Rider Rider;

	public Cavalo(int id,string nome, string raca, int velocidade, int stamina, bool saude, int dono, int valor,Rider rider) : base(id,nome,raca,velocidade,stamina,saude,dono,valor)
	{
		this.Rider = rider;
	}

	
}