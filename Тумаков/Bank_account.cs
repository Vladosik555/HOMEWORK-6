using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Bank_account
    {
        private int number;

        public int Number { get { return number; } set { number = value; } }


        private int balance;

        public int Balance { get { return balance; } set { balance = value; } }

        private Bank type;
        public Bank Type { get { return type; } set { type = value; } }
    }
}
