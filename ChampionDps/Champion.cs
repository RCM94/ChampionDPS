using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    enum DamageType
    {
        Physical,
        Magic,
        True
    }

    class Champion
    {
        public Champion()
        {
            stats = new Stat[Enum.GetNames(typeof(StatType)).Length];
            stats[(int)StatType.AP] = new Stat(100, 0);
            Spell a = new Spell();
        }

        public Champion(List<Spell> newSpells, Stat[] newStats)
        {
            spells = newSpells;
            stats = newStats;
        }

        internal List<Spell> Spells
        {
            get
            {
                return spells;
            }
        }

        internal static Stat[] Stats
        {
            get
            {
                return stats;
            }
        }

        public static int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        private List<Spell> spells;
        private static Stat[] stats;
        private static int level; 
    }
}
