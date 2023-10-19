using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Bank_account2
    {
        private static int number;
        public void SetNumber(int number_1)
        {
            Bank_account2.number = number_1;
        }
        public int PrintNumber()
        {
            return number++;
        }

        private int balance;

        public int Balance { get { return balance; } set { balance = value; } }

        private Bank type;
        public Bank Type { get { return type; } set { type = value; } }
    }
}
