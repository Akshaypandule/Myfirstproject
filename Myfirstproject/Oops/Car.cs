using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Car
    {
        public int model_number;
        public string car_name;
        public int car_price;
        public string car_color;

        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.car_name = "Audi";
            audi.car_color = "Black";
            audi.car_price = 7800000;
            audi.model_number = 6589;
            Console.WriteLine(audi.car_name + " " + audi.car_color + " " + audi.car_price + " " + audi.model_number);

            Car creta = new Car();
            creta.car_name = "Creta";
            creta.car_color = "White";
            creta.car_price = 140000;
            creta.model_number = 2133;
            Console.WriteLine(creta.car_name + " " + creta.car_color + " " + creta.car_price + " " + creta.model_number);

            Car I20 = new Car();
            I20.car_name = "I20";
            I20.car_color = "red";
            I20.car_price = 700000;
            I20.model_number = 1493;
            Console.WriteLine(I20.car_name + "  " + I20.car_color + "  " + I20.car_price + " " + I20.model_number);

            Car XUV = new Car();
            XUV.car_name = "XUV";
            XUV.car_color = "Black";
            XUV.car_price = 1350000;
            XUV.model_number = 356;
            Console.WriteLine(XUV.car_name + " " + XUV.car_color + " " + XUV.car_price + " " + XUV.model_number);
        }






    }


}
