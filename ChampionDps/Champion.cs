using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class Champion : Unit
    {
        public Champion() : base()
        {
            Spell a = new Spell();
        }

        public Champion(List<Spell> newSpells, Stat[] newStats) : base(newStats)
        {
            spells = newSpells;
            baseStats = newStats;
        }

        internal List<Spell> Spells
        {
            get
            {
                return spells;
            }
        }

        private List<Spell> spells;
    }
}
