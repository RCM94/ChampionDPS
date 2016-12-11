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
        public Spell()
        {
            double c = Champion.Stats[(int)StatType.AP].Item1;
            int a = 0;
            int b = a;
        }
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
                return cooldown*(1-Champion.Stats[(int) StatType.CDR].Item2);
            }

            set
            {
                cooldown = value;
            }
        }

        public static int IncrementLevel()
        {
            level++;
            return level;
        }

        private List<Damage> damages;
        private double cooldown;
        private static int level;

        
    }
}
