using System;

public class Calendario
{
	public int dia { get; set; }
	public int mes { get; set; }
	public int ano { get; set; }

	public Calendario()
	{

	}

	public Calendario(int Dia, int Mes, int Ano)
	{
		this.dia = Dia;
		this.mes = Mes;
		this.ano = Ano;
	}

}
