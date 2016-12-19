using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class Active : Spell
    {
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

        private int maxCharges;
    }
}
