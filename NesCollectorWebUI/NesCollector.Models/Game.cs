using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class Game
    {
        public string Id { get; set; }
        public string ApiGameId { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string CoverURL { get; set; }
        public string Upc { get; set; }

    }
}
