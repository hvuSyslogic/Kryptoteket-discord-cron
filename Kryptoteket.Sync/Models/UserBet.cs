﻿using System;

namespace Kryptoteket.Sync.Models
{
    public class UserBet
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string BetId { get; set; }
        public DateTimeOffset? BetPlaced { get; set; }
    }
}
