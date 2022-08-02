using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Racecar
    {
        string car_name;
        int model_no;
        int price;
        int speed;

        public string Car_name
        {
            get
            {
                return car_name;
            }
            set
            {
                car_name = value;
            }
        }
        public int Model_no
        {
            get
            {
                return model_no;
            }
            set
            {
                model_no = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }

    class cardetails
    {
        static void Main(string[] args)
        {
            Racecar b = new Racecar();
            b.Car_name = "Ferrari";
            b.Model_no = 40;
            b.Price = 37000000;
            b.Speed = 211;

            Console.WriteLine(b.Car_name + " " + b.Model_no + " " + b.Price + " " + b.Speed);

        }
    }
}
