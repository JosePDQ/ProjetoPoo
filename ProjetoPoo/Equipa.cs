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

	public int money { get; set; }



	public Equipa()
	{
		staff = new List<Staff>();
		rider = new List<Rider>();
		cavalos = new List<Cavalo>();

	}

	public Equipa(int Id, string Nome, List<Staff> Staff, List<Rider> Rider, List<Cavalo> Cavalos, List<Galro> Galros)
	{
		this.id = Id;
		this.nome = Nome;
		this.staff = Staff;
		this.rider = Rider;
		this.cavalos = Cavalos;
		this.money = 100000;
	}

   
}
