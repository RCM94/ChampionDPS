using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class Spell
    {
        public Spell()  {}

        public static int Level
        {
            get
            {
                return level;
            }
        }

        internal List<Damage> Damages
        {
            get
            {
                return damages;
            }

            set
            {
                damages = value;
            }
        }

        public double Cooldown
        {
            get
            {
                return cooldown*(1-Champion.GetStat(StatType.CDR));
            }

            set
            {
                cooldown = value;
            }
        }

        public int MaxCharges
        {
            get
            {
                return maxCharges;
            }

            set
            {
                maxCharges = value;
            }
        }

        public int IncrementLevel()
        {
            level++;
            return level;
        }

        private int maxCharges;
        private List<Damage> damages;
        private double cooldown;
        private static int level = 1;
    }
}
