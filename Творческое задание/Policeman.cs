using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    internal class Policeman
    {
        private int luck;
        public void SetLuck(int luck)//высота здания
        {
            this.luck = luck;
        }
        public void GetLuck()
        {
            if (this.luck < 5)
            {
                Console.WriteLine("Тебе не повезло, полицейский нашел твои наркотики и посадил тебя в тюрьму");
            }
            else
            {
                Console.WriteLine("Тебе повезло, полицейский не нашел твои наркотики и отпустил тебя домой");
            }
        }
    }
}
