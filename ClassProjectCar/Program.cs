using System;
using System.Collections.Generic;

namespace ClassProjectCar
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var Car1 = new Car();
            Car1.Make = "Honda";
            Car1.Model = "Civic";
            Car1.Year = 2017;

            var Car2 = new Car();
            Car2.Make = "Dodge";
            Car2.Model = "Ram";
            Car2.Year = 1980;

            var AllCars = new List<Car>();

            AllCars.Add(Car1);
            AllCars.Add(Car2);

            foreach (var eachCar in AllCars)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($" Make: {eachCar.Make}");
                Console.WriteLine($" Model: {eachCar.Model}");
                Console.WriteLine($" Year: {eachCar.Year}");

                //Console.WriteLine($"Make: {Car1.Make}, Model: {Model}, Year: {Year}");
            }

        }
    }
}
