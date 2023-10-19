using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    enum Bank
    {
        текущий,
        сберегательный
    }

    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("Данная программа показывает счет, баланс и тип банковского счета");
            Bank_account bank = new Bank_account();
            bank.Number = 12345;
            int number = bank.Number;
            Console.WriteLine($"Номер карты: {number}");
            bank.Balance = 10000;
            int balance = bank.Balance;
            Console.WriteLine($"Ваш баланс составляет: {balance} долларов");
            bank.Type = Bank.текущий;
            Bank type = bank.Type;
            Console.WriteLine($"Тип банковского счёта: {type}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 7.2");
            Console.WriteLine("программа из 7.1 с уникальных кодом");
            Bank_account2 bank1 = new Bank_account2();
            Random random = new Random();
            int random1 = random.Next(0,100000);
            bank1.SetNumber(random1);
            int number1 = bank1.PrintNumber();
            Console.WriteLine($"Номер карты: {number1}");
            bank1.Balance = 10000;
            int balance1 = bank1.Balance;
            Console.WriteLine($"Ваш баланс составляет: {balance1} долларов");
            bank1.Type = Bank.текущий;
            Bank type1 = bank1.Type;
            Console.WriteLine($"Тип банковского счёта: {type1}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 7.3");
            Console.WriteLine("Данная программа позволяет положить или снять деньги со счёта");
            Bank_account3 bank2 = new Bank_account3();
            Random random2 = new Random();
            bank2.Set(10000);
            Console.WriteLine($"На вашем счёте {bank2.Set(10000)}");
            int random3 = random2.Next(0, 100000);
            bank2.PrintBalance();
            Console.WriteLine("\nВыберите операцию: снять или положить средства");
            string operation = Console.ReadLine();
            Console.WriteLine("Напишите сумму");
            bool flag = uint.TryParse(Console.ReadLine(), out  uint balance2);
            if (flag)
            {
                bank2.SetBalance(operation, balance2);
                Console.WriteLine($"Ваш баланс: {bank2.PrintBalance()}");
            }
            else
            {
                Console.WriteLine("Нельзя водить символы, буквы или отрицательный числа");
            }
            bank2.SetNumber(random3);
            int number2 = bank2.PrintNumber();
            Console.WriteLine($"Номер карты: {number2}");
            bank2.Type = Bank.текущий;
            Bank type2 = bank2.Type;
            Console.WriteLine($"Тип банковского счёта: {type2}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 7.1");
            Console.WriteLine("Задание с квартирами");
            Apartment apartment = new Apartment();
            Random rand = new Random();
            int rand_1 = rand.Next(1, 1000);
            apartment.SetNumb(rand_1);
            Console.Write("Напишите количество этажей: ");
            bool flag1 = uint.TryParse(Console.ReadLine(), out uint floor);
            if (flag1)
            {
                apartment.SetFlo(floor);
            }
            else
            {
                Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
            }
            Console.Write($"Введите количество подъездов: ");
            bool flag2 = uint.TryParse(Console.ReadLine(), out uint quantity_entr);
            if (flag2)
            {
                apartment.SetQuan_entr(quantity_entr);
            }
            else
            {
                Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
            }
            Console.Write("Введите высоту здания: ");
            bool flag3 = uint.TryParse(Console.ReadLine(), out uint heagth);
            if (flag3)
            {
                apartment.SetHeig(heagth);
            }
            else
            {
                Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
            }
            Console.Write("Введите количество квартир: ");
            bool flag4 = uint.TryParse(Console.ReadLine(), out uint quantity_apart);
            if (flag4)
            {
                apartment.SetQuan_apart(quantity_apart);
            }
            else
            {
                Console.WriteLine("Нельзя вводить отрицательный числа, символы и буквы ");
            }
            Console.WriteLine();
            Console.WriteLine($"Уникальный номер здания: {apartment.PrintNumb()}");
            Console.WriteLine($"Высота: {apartment.PrintHeig()} метров");
            Console.WriteLine($"Этажность: {apartment.PrintFlo()}");
            Console.WriteLine($"Количество квартир: {apartment.PrintQuan_apart()}");
            Console.WriteLine($"Количество подъездов: {apartment.PrintQuan_entr()}");
            Console.WriteLine($"Высота этажа: {apartment.Heigth(heagth, floor)} метров");
            Console.WriteLine($"Количество квартир в подъезде: {apartment.Quantity_apart_inENTR(quantity_apart , quantity_entr)}");
            Console.WriteLine($"Количество квартир на этаже: {apartment.Quantity_apart_infloor(quantity_apart , floor)} ");
            Console.WriteLine("\nДля того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();




        }
    }
}
