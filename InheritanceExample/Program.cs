using System;

namespace InheritanceExample
{
    class Program
    {
        // Base Class

        public class Vehicle
        {

            public string name { get; set; }
            private string make { get; set; }
            public Vehicle()
            {
                Console.WriteLine(" I am in the Constructor Vehicle");
            }

            public void set_Vname(string v_name)
            {
                name = v_name;
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

            Truck truck_obj = new Truck();
            truck_obj.name = "Mercedes";
            truck_obj.set_Vname("Toyota");
            
        }

    }
}
