using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int ApiGameId { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string CoverURL { get; set; }
        public string Upc { get; set; }
        public double LoosePrice { get; set; }
        public double CibPrice { get; set; }

        //foreign key
        public int GameConsoleId { get; set; }
        public GameConsole GameConsole { get; set; }

    }
}
