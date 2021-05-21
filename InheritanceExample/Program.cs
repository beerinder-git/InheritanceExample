using System;

namespace InheritanceExample
{
    class Program
    {
        // Base Class

        public class Vehicle
        {
            public Vehicle()
            {
                Console.WriteLine(" I am in the Constructor Vehicle");
            }
        }

        // Derived Class
        public class Truck : Vehicle
        {
            public Truck()
            {
                Console.WriteLine("I am in the Derived Truck");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}
