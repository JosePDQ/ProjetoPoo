using System;
using System.Collections.Generic;
using System.Text;


    class Game
    {
        public Calendario DiaAtual { get; set; }
        public Game()
        {
            DiaAtual = new Calendario(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }

        public void AvancarDia()
        {
            DiaAtual.dia++;
            if (DiaAtual.dia > DateTime.DaysInMonth(DiaAtual.ano, DiaAtual.mes))
            {
                DiaAtual.dia = 1;
                DiaAtual.mes++;
                if (DiaAtual.mes > 12)
                {
                    DiaAtual.mes = 1;
                    DiaAtual.ano++;
                }
            }
        }

    
    }

