using System;
using AbstractFactory.Objects;

namespace AbstractFactory
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            var Eevee = new Pokemon<Eevee>();
            Eevee.RunType();
            Eevee.RunTypeStrongAgainst();
            Eevee.RunTypeWeakAgainst();

            // Create and run the African animal world
            var Pikachu = new Pokemon<Pikachu>();
            Pikachu.RunType();
            Pikachu.RunTypeStrongAgainst();
            Pikachu.RunTypeWeakAgainst();

            Console.ReadKey();
        }
    }
}
