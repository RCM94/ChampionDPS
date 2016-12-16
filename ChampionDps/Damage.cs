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

    class Damage
    {
        public Damage(DamageType dmgType)
        {
            Type = dmgType;
        }

        protected DamageType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        private DamageType type;
    }
}
