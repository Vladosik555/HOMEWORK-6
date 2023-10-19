using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Bank_account3
    {
        private static int number;
        public void SetNumber(int number_1)
        {
            Bank_account3.number = number_1;
        }
        public int PrintNumber()
        {
            return number++;
        }

        private static uint balance;
        public uint Set(uint balance1)
        {
            Bank_account3.balance = balance1;
            return balance;
        }
        public void SetBalance(string operation, uint value)
        {
            switch (operation)
            {
                case "положить":
                    Bank_account3.balance += value;
                    break;
                case "снять":
                    if (value > balance)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    else
                    {
                        balance -= value;
                    }
                    break;
                default:
                    Console.WriteLine("Такой операция нет");
                    break;
            }
        }
        public uint SetBalan(int balance_1)
        {
            Bank_account3.number = balance_1;
            return balance;
        }
        public uint PrintBalance()
        {
            return balance;
        }

        public uint Balance { get { return balance; } set { balance = value; } }

        private Bank type;
        public Bank Type { get { return type; } set { type = value; } }
    }
}
