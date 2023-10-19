using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    internal class Notlegal_Pawnshop : Pawnshop
    {
        private uint gruds;
        public uint Gruds { get { return gruds; } set { gruds = value; } }

        public Notlegal_Pawnshop(uint silver, uint platinum, uint gold, uint gruds) : base(silver, platinum, gold)
        {
            this.gruds = gruds;
        }

        public override void Price()
        {
            uint count_silv = silver * 200;
            uint count_plat = platinum * 4000;
            uint count_golg = gold * 3000;
            uint count_gruds = gruds * 5000;
            Console.WriteLine($"Цена за серебро: {count_silv} рублей");
            Console.WriteLine($"Цена за платину: {count_plat} рублей");
            Console.WriteLine($"Цена за золото: {count_golg} рублей");
            Console.WriteLine($"Цена за косячок {count_gruds} рублей");
        }
        public override void CalculatePrice()
        {
            uint count_silv = silver * 200;
            uint count_plat = platinum * 4000;
            uint count_golg = gold * 3000;
            uint count_gruds = gruds * 5000;
            uint result = count_silv + count_plat + count_golg + count_gruds;
            Console.WriteLine($"Полная стоимость за товар: {result} рублей");
        }
        public override void Finish()
        {
            Console.WriteLine("Вы завершили покупку");
        }
    }
}
