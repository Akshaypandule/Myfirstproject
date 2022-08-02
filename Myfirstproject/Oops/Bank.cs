using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Bank
    {
        string c_name;
        int acc_number;
        int acc_balance;

        public string C_Name
        {
            get
            {
                return c_name;
            }
            set
            {
                c_name = value;
            }
        }
        public int Acc_Number
        {
            get
            {
                return acc_number;
            }
            set
            {
                acc_number = value;
            }
        }
        public int Acc_Balance
        {
            get
            {
                return acc_balance;
            }
            set
            {
                acc_balance = value;
            }
        }
    }
    class accountdetails
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.C_Name = "Akshay";
            b.Acc_Number = 658455156;
            b.Acc_Balance = 65000;

            Console.WriteLine(b.C_Name+" "+ b.Acc_Number+" "+ b.Acc_Balance);
        }
    }

}
