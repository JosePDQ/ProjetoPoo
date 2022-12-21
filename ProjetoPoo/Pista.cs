using System;

public class Pista
{
	public string nome { get; set; }
	public int distancia { get; set; }
	public Pista()
	{
	}
	public Pista(string Nome, int Distancia)
    {
		this.nome = Nome;
		this.distancia = Distancia;
    }
}
