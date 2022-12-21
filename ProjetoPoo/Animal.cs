using System;


public class Animal
{
	public int id { get; set; }
	public string nome;
	public string raca;
	public int velocidade;
	public int stamina;
	public bool saude;
	public int dono;
	public int valor;
	public Animal(int Id,string nome, string raca, int velocidade, int stamina, bool saude, int dono, int valor)
	{
		this.id = Id;
		this.nome = nome;
		this.raca = raca;
		this.velocidade = velocidade;
		this.stamina = stamina;
		this.saude = saude;
		this.dono = dono;
		this.valor = valor;
		

	}

}
