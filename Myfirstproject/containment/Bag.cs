using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.containment
{
    class Pen
    {
        string name;
        string colour;
        string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Bag
    {
        string brand_name;
        int price;
        string colour;
        Pen pn;

        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Pen Pn
        {
            get { return pn; }
            set { pn = value; }
        }

    }
    class Baginfo
    {
        static void Main(string[] args)
        {
            Bag d = new Bag();
            d.Brand_name = "American Tourister";
            d.Price = 1900;
            d.Colour = "blue";
            d.Pn = new Pen();
            d.Pn.Name = "Natraj";
            d.Pn.Colour = "Black";
            d.Pn.Type = "ballpen";

            Console.WriteLine(d.Brand_name+"  "+ d.Price+"  "+ d.Colour+"  "+ d.Pn.Name+"  "+ d.Pn.Colour+"  "+ d.Pn.Type);
        }
    }
}
