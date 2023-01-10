using System;
using System.Collections.Generic;
using System.Text;

namespace EventosSpace
{
    public enum TipoEvento
    {
        Treino,
        Media,
        Descanço,
    }

    public class Evento
    {
        public int id { get; set; }
        public TipoEvento tipoEvento { get; set; }
        public int teamId { get; set; }
        public Calendario data { get; set; }

        public Evento(int id, TipoEvento tipoEvento, int TeamId, Calendario data)
        {
            this.id = id;
            this.tipoEvento = tipoEvento;
            this.teamId = TeamId;
            this.data = data;
        }

    }
}

