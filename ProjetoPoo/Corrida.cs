using System;
using System.Collections.Generic;

public class Corrida
{
	public Calendario dia { get; set; }
	public Pista pista { get; set; }
	public List<Animal> participantes { get; set; }
	public string tipo { get; set; }
	public Corrida()
	{
		participantes = new List<Animal>();
	}

	public Corrida(Calendario Dia, Pista Pista, List<Animal> Participantes, string Tipo)
	{
		this.dia = Dia;
		this.pista = Pista;
		this.participantes = Participantes;
		this.tipo = Tipo;

	}
}
