using System;
using System.Collections.Generic;
using System.Text;

class Cavalo : Animal
{
	public int rider;

	public Cavalo(string nome, string raca, int velocidade, int stamina, bool saude, int dono, int valor,int rider) : base(nome,raca,velocidade,stamina,saude,dono,valor)
	{
		this.rider = rider;
	}

	
}
