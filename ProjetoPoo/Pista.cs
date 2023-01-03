using System;

public class Pista
{
	public int id { get; set; }
	public string nome { get; set; }
	public float comprimento { get; set; }
	public Pista()
	{
	}
	public Pista(int Id,string Nome, float Comprimento)
    {
		this.id = Id;
		this.nome = Nome;
		this.comprimento = Comprimento;
    }
}
