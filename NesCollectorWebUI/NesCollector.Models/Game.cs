using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string SystemId { get; set; }
        public string CoverURL { get; set; }
        public int Upc { get; set; }

    }
}
