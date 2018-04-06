﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Library
{
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BattleId { get; set; }
        public List<Quote> Quotes { get; set; }

    }
}