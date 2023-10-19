using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Творческое_задание
{
     
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Творческое задание");
            Console.WriteLine("Вы проснулись рано утром и вспомнили, что завтра 8 марта и вам нужно сходить в ломбард");
            Thread.Sleep(2000);
            Console.WriteLine("Но вы наркозависимый и не отказались бы купить себе косяка");
            Thread.Sleep(2000);
            Console.WriteLine("Вы знаете что, в легальном ломбарде можно купить только серебро, платина, золото, а в нелегальном можно купить и косяка");
            Thread.Sleep(2000);
            Console.WriteLine("Выберите ломбард, в который захотите пойти (легальный или нелегальный)");
            string type = Console.ReadLine();
            type = type.ToLower();
            if (type == "нелегальный")
            {
                Console.WriteLine("Сейчас вы будет покупать драгоценные металлы своей возлюбленной");
                Thread.Sleep(2000);
                Console.WriteLine($"Цена серебра - 200 рублей за грамм , цена золота - 3000 рублей за грамм, цена платины 4000 рублей за грамм" +
                "цена 5000 рублей");
                Console.Write("Напишите сколько грамм серебренных украшений вы купите своей девушке: ");
                bool flag1 = uint.TryParse( Console.ReadLine(), out uint silver);
                if (flag1)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Console.Write("Напишите сколько грамм платиновых украшений вы купите своей девушке: ");
                bool flag2 = uint.TryParse(Console.ReadLine(), out uint platinum);
                if (flag2)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Console.Write("Напишите сколько грамм золотых украшений вы купите своей девушке: ");
                bool flag3 = uint.TryParse(Console.ReadLine(), out uint gold);
                if (flag3)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Console.Write("Напишите сколько грамм косяка вы купите себе: ");
                bool flag4 = uint.TryParse(Console.ReadLine(), out uint gruds);
                if (flag4)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Notlegal_Pawnshop notlegal = new Notlegal_Pawnshop(silver, platinum, gold, gruds);
                notlegal.Price();
                notlegal.CalculatePrice();
                notlegal.Finish();
                Console.WriteLine("Вы идете довольный домой");
                Thread.Sleep(2000);
                Console.WriteLine("Сейчас я приду, покурю косячок и завтра подарю драгоценности своей девушке");
                Thread.Sleep(2000);
                Console.WriteLine("Но вдруг вы встречаете полицейского");
                Thread.Sleep(2000);
                Console.WriteLine("Он представляется перед вами и начинает вас обыскивать связи из-за большого распространения наркотиков");
                Policeman policeman = new Policeman();
                Random rand = new Random();
                int random = rand.Next(1, 10);
                if (gruds == 0)
                {
                    Console.WriteLine("Полицейский не находит наркотики и отпускает вас домой");
                }
                else
                {
                    policeman.SetLuck(random);
                    policeman.GetLuck();
                }
                if (random > 5 && gruds > 50)
                {
                    Console.WriteLine("Вы выкурили более 50 грамма косяка, после чего вы не проснулись");
                }
                else if (gruds == 0)
                {
                    Console.WriteLine("Вы не купили себе косяка и легли спать, после порадывали свою девушку подарком");
                }
                else
                {
                    Console.WriteLine("Вы выкурили косяк и легли спать на следующий день вы подарил драгоценности своей девушке, она была очень рада ");
                }
                Console.WriteLine("Игра окончена");
                
            }
            else if (type == "легальный")
            {
                int gruds = 0;
                Console.Write("Напишите сколько грамм серебренных украшений вы купите своей девушке: ");
                bool flag1 = uint.TryParse(Console.ReadLine(), out uint silver);
                if (flag1)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Console.Write("Напишите сколько грамм платиновых украшений вы купите своей девушке: ");
                bool flag2 = uint.TryParse(Console.ReadLine(), out uint platinum);
                if (flag2)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Console.Write("Напишите сколько грамм золотых украшений вы купите своей девушке: ");
                bool flag3 = uint.TryParse(Console.ReadLine(), out uint gold);
                if (flag3)
                {
                }
                else
                {
                    Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
                }
                Legal_Pawnshop legal = new  Legal_Pawnshop(silver, platinum, gold);
                legal.Price();
                legal.CalculatePrice();
                legal.Finish();
                Console.WriteLine("Вы идете довольный домой");
                Thread.Sleep(2000);
                Console.WriteLine("Но вдруг вы встречаете полицейского");
                Thread.Sleep(2000);
                Console.WriteLine("Он представляется перед вами и начинает вас обыскивать связи из-за большого распространения наркотиков");
                if (gruds == 0)
                {
                    Console.WriteLine("Полицейский не находит наркотики и отпускает вас домой");
                }
                else
                {
                    Policeman policeman = new Policeman();
                    Random rand = new Random();
                    int random = rand.Next(1, 10);
                    policeman.SetLuck(random);
                    policeman.GetLuck();
                }
                Console.WriteLine("Вы приходите домой и ложитесь спать, на следующий день вы дарите драгоценности своей девушке, она была очень рада");
                Thread.Sleep(2000);
                Console.WriteLine("Игра окончена");
            }
            else
            {
                Console.WriteLine("Вы решили никуда не идти и остались в гордом одиночестве");
            }

            Console.WriteLine("Для того чтобы закрыть программу ,нажмите на любую клавишу");
            Console.ReadKey();


            


        }
    }
}
