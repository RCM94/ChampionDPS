using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    abstract class Unit
    {

        public Unit()
        {
            baseStats = new Stat[Enum.GetNames(typeof(StatType)).Length];
            bonusStats = new Stat[Enum.GetNames(typeof(StatType)).Length];
            level = 1;
        }

        public Unit(Stat[] newStats)
        {
            baseStats = newStats;
            bonusStats = new Stat[Enum.GetNames(typeof(StatType)).Length];
            level = 1;
        }

        internal static Stat[] BaseStats
        {
            get
            {
                return baseStats;
            }
        }

        internal static Stat[] BonusStats
        {
            get
            {
                return bonusStats;
            }

            set
            {
                bonusStats = value;
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

        public static double GetStat(StatType stat)
        {
            int ind = (int)stat;
            return baseStats[ind].GetValue(Level) + bonusStats[ind].GetValue(Level);
        }

        protected static Stat[] baseStats;
        protected static Stat[] bonusStats;
        protected static int level;
    }
}
