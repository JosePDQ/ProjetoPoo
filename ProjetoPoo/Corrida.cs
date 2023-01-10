using System;
using System.Collections.Generic;

namespace CorridasSpace
{
	public enum TipoCorrida
	{
		Obstáculos,
		Sprint,
		Maratona,
	}
	public class Corrida
	{
		public Calendario data { get; set; }
		public Pista pista { get; set; }
		public List<Cavalo> participantes { get; set; }
		public TipoCorrida tipo { get; set; }
		public Corrida()
		{
			participantes = new List<Cavalo>();
		}

		public Corrida(Calendario Dia, Pista Pista, List<Cavalo> Participantes, TipoCorrida Tipo)
		{
			this.data = Dia;
			this.pista = Pista;
			this.participantes = Participantes;
			this.tipo = Tipo;

		}
	}
}