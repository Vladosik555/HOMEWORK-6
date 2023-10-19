using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    internal class Legal_Pawnshop : Pawnshop
    {
        public Legal_Pawnshop(uint silver, uint platinum, uint gold) : base(silver, platinum, gold) { }

        public override void Price()
        {
            uint count_silv = silver * 200;
            uint count_plat = platinum * 4000;
            uint count_golg = gold * 3000;
            Console.WriteLine($"Цена за серебро: {count_silv} рублей");
            Console.WriteLine($"Цена за платину: {count_plat} рублей");
            Console.WriteLine($"Цена за золото: {count_golg} рублей");
        }
        public override void CalculatePrice()
        {
            uint count_silv = silver * 200;
            uint count_plat = platinum * 4000;
            uint count_golg = gold * 3000;
            uint result = count_silv + count_plat + count_golg;
            Console.WriteLine($"Полная стоимость за товар: {result} рублей");
        }
        public override void Finish()
        {
            Console.WriteLine("Вы завершили покупку");
        }
    }
}
