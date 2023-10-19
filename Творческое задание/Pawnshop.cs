using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    abstract internal class Pawnshop
    {
        protected uint silver;
        public uint Silver { get { return silver; } set { silver = value; } }

        protected uint platinum;
        public uint Platinum { get { return platinum; } set { platinum = value; } }

        protected uint gold;

        public uint Gold { get { return gold; } set { gold = value; } }

        public Pawnshop(uint silver, uint platinum, uint gold)
        {
            this.silver = silver;
            this.platinum = platinum;
            this.gold = gold;
        }

        public abstract void Finish();
        public abstract void CalculatePrice();
        public abstract void Price();
    }
}
