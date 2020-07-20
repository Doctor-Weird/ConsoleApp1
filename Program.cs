using System;
using System.Runtime.CompilerServices;
using Vehicles;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new PassengerTrain());
            Console.ReadKey();
            
            
        }
        static void AddPassenger(IPassengerCarrier passengerCarrier)
        {
            Console.WriteLine(passengerCarrier.ToString());
        }
    }
}