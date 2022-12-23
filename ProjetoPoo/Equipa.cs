using System;
using System.Collections.Generic;
using System.Text;
using StaffSpace;
public class Equipa
{
	public int id { get; set; }
	public string nome { get; set; }
	public List<Staff> staff { get; set; }
	public List<Rider> rider { get; set; }

	public List<Cavalo> cavalos { get; set; }
	public List<Galro> galros { get; set; }




	public Equipa()
	{
		staff = new List<Staff>();
		rider = new List<Rider>();
		cavalos = new List<Cavalo>();
		galros = new List<Galro>();

	}

	public Equipa(int Id, string Nome, List<Staff> Staff, List<Rider> Rider, List<Cavalo> Cavalos, List<Galro> Galros)
	{
		this.id = Id;
		this.nome = Nome;
		this.staff = Staff;
		this.rider = Rider;
		this.cavalos = Cavalos;
		this.galros = Galros;
	}

   
}
