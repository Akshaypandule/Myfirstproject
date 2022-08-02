using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Animal
    {
        public string animal_name;
        public int animal_number_legs;
        public string animal_food;
        static void Main(string[] args)
        {
            Animal lion = new Animal();
            lion.animal_name = "Lion";
            lion.animal_number_legs = 4;
            lion.animal_food = "Carnivore";
            Console.WriteLine(lion.animal_name + " " + lion.animal_number_legs + " " + lion.animal_food);

            Animal rabbit = new Animal();
            rabbit.animal_name = "rabbit";
            rabbit.animal_number_legs = 4;
            rabbit.animal_food = "Vegetarian";
            Console.WriteLine(rabbit.animal_name + " " + rabbit.animal_number_legs + " " + rabbit.animal_food); ;
        }
    }
}
