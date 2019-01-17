using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public bool Brutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BattleLog Battlelog { get; set; }
        public int BattleLogId { get; set; }

        public List<SamuraiBattle> SamuraiBattle { get; set; }

        public string Summary { get; set; }
    }
}
