using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bonus_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Nikolai", "Model S", 2019, 54999.90));
            cars.Add(new Car("Fourd", "Escapade", 2019, 31999.90));
            cars.Add(new Car("Chewie", "Vette", 2019, 44989.95));
            cars.Add(new UsedCar("Hyonda", "Prior", 2017, 14795.50, 35987.6));
            cars.Add(new UsedCar("GC", "Chirpus", 2015, 8500, 12345));
            cars.Add(new UsedCar("GC", "Witherell", 2016, 14450, 3500.3));

            foreach (var c in cars)
            {
                if (c is UsedCar)
                {
                    ((UsedCar)c).ToString();
                }
                else
                {
                    c.ToString();
                }
                Console.WriteLine(c);
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Which car would you like?");
                int selection = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine();
                Console.WriteLine(cars[selection]);

                Console.WriteLine();
                Console.Write("Would you like to buy this car? (Y/N)");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
                    cars.Remove(cars[selection]);
                }
                else
                {
                    break;
                }

                Console.WriteLine();
                foreach (var c in cars)
                {
                    if (c is UsedCar)
                    {
                        ((UsedCar)c).ToString();
                    }
                    else
                    {
                        c.ToString();
                    }
                    Console.WriteLine(c);
                }
                break;
            }
            Console.WriteLine("Have a great day!");
        }
    }
}
