using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class FlatDamage : Damage
    {
        private FlatDamage(double baseVal, double scalingVal, DamageType dmgType) : base(dmgType)
        {
            BaseDamage = baseVal;
            Scaling = scalingVal;
        }

        public double BaseDamage
        {
            get
            {
                return baseDamage + damagePerLevel*Spell.Level;
            }

            set
            {
                baseDamage = value;
            }
        }

        public double Scaling
        {
            get
            {
                return scaling + scalingPerLevel*Spell.Level;
            }

            set
            {
                scaling = value;
            }
        }

        public double DamagePerLevel
        {
            get
            {
                return damagePerLevel;
            }

            set
            {
                damagePerLevel = value;
            }
        }

        public double ScalingPerLevel
        {
            get
            {
                return scalingPerLevel;
            }

            set
            {
                scalingPerLevel = value;
            }
        }

        private double baseDamage;
        private double damagePerLevel;
        private double scaling;
        private double scalingPerLevel;
    }
}
