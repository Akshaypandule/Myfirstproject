using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3             
{
    class Overloading
    {
       
        public void do_transaction(int credit_card)
        {
            Console.WriteLine("You got 15% discount  on bill on credit card transaction");
        }
        public void do_transaction(float Debit_card)
        { 
             Console.WriteLine("No discount on bill on debit card transaction");     
        }
        static void Main(string[] args)
        {
            Overloading a = new Overloading();
            a.do_transaction(5000);
            a.do_transaction(300.0f);
        }
    }

   
   





}
