﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class Item
    {
        internal List<Spell> Spells
        {
            get
            {
                return spells;
            }

            set
            {
                spells = value;
            }
        }


        private List<Stat> stats;
        private List<Spell> spells;
    }
}
