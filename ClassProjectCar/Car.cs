using System;
namespace ClassProjectCar
{
    public class Car
    {
        public string Make { set; get; }
        public string Model { set; get; }
        public double Year { set; get; }

        public void WriteOutCar()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
        
    }
}
