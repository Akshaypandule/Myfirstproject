using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulate
{
    class Order
    {
        int oid;
        string product_name;
        int price;
        int qty;
        int total_bill;

        Order(int oid,string product_name,int qty,int price)
        {
            this.oid = oid;
            this.product_name = product_name;
            this.qty = qty;
            this.price = price;
        }
        Order():this(1,"pendrive",5,400)
        {
            total_bill = price * qty;
            this.Display();
        }
        void Display()
        {
            Console.WriteLine(oid+" "+product_name+" "+price+" "+qty+" "+total_bill);
        }

        static void Main(string[] args)
        {
            Order r = new Order();
        }
    }
}
