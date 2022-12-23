using System;
using System.Collections.Generic;
using System.Text;


public class Animal
{
	public int id;
	public string nome;
	public string raca;
	public int velocidade;
	public int stamina;
	public bool saude;
	public float valor;


	public Animal(int Id,string nome, string raca, int velocidade, int stamina, bool saude, float valor)
	{
		this.id = Id;
		this.nome = nome;
		this.raca = raca;
		this.velocidade = velocidade;
		this.stamina = stamina;
		this.saude = saude;
		this.valor = valor;
	
	}

}
