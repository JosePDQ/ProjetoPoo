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

        

    
    }

