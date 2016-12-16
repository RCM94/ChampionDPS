using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionDps
{
    class OnHit
    {
        public double Magic
        {
            get
            {
                return magic;
            }

            set
            {
                magic = value;
            }
        }

        public double PercentMagic
        {
            get
            {
                return percentMagic;
            }

            set
            {
                percentMagic = value;
            }
        }

        public double Physical
        {
            get
            {
                return physical;
            }

            set
            {
                physical = value;
            }
        }

        private double magic;
        private double percentMagic;
        private double physical;
    }
}
