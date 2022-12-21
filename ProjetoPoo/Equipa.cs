using System;
using System.Collections.Generic;
using System.Text;
public class Equipa
{
	public int id { get; set; }
	public string nome { get; set; }
	public List<Pessoa> membros { get; set; }

	public Equipa()
	{
		membros = new List<Pessoa>();
	}

	public Equipa(int Id, string Nome, List<Pessoa> Membros)
	{
		this.id = Id;
		this.nome = Nome;
		this.membros = Membros;
	}
}
