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

        public int IncrementLevel()
        {
            level++;
            return level;
        }

        
        protected List<Damage> damages;
        protected double cooldown;
        protected static int level = 1;
    }
}
