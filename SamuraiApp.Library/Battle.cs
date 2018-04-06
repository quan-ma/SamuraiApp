using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Library
{
    public class Battle
    {
        public int Id { get; set; }
        public string BattleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Samurai> Samurais { get; set; }

    }
}
