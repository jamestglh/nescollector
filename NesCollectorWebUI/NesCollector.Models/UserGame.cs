using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class UserGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string SystemId { get; set; }
        public string Condition { get; set; }
        public bool HasBox { get; set; }
        public bool HasManual { get; set; }
        public bool IsCIB { get; set; }
        public double Value { get; set; }

        //foreign keys
        public string UserId { get; set; }
        public AppUser User { get; set; } //navigation reference
        public int GameId { get; set; }
        public Game Game { get; set; } //navigation reference


    }
}
