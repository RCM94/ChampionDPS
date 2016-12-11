using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class PercentDamage : Damage
    {
        public PercentDamage(double baseVal, double scalingVal, DamageType dmgType) : base(dmgType)
        {
            BasePercent = baseVal;
            Scaling = scalingVal;
        }

        public double BasePercent
        {
            get
            {
                return basePercent + percentPerLevel*Level;
            }

            set
            {
                basePercent = value;
            }
        }

        public double Scaling
        {
            get
            {
                return scaling + scalingPerLevel*Level;
            }

            set
            {
                scaling = value;
            }
        }

        public double PercentPerLevel
        {
            get
            {
                return percentPerLevel;
            }

            set
            {
                percentPerLevel = value;
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

        private double basePercent;
        private double percentPerLevel;
        private double scaling;
        private double scalingPerLevel;
    }
}
