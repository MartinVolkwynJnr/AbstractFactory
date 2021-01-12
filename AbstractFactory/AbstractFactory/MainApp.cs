using System;
using AbstractFactory.Objects;

namespace AbstractFactory
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Create and run the African animal world
            var africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();

            // Create and run the American animal world
            var america = new AnimalWorld<America>();
            america.RunFoodChain();

            Console.ReadKey();
        }
    }
}
