using System;
using AbstractFactory.Objects;

namespace AbstractFactory
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Pokemon World");

            // Create and run the African animal world
            var Alola = new PokemonWorld<Alola>();
            Alola.WhoHasTypeAdvantage();

            // Create and run the American animal world
            var Indigo = new PokemonWorld<Indigo>();
            Indigo.WhoHasTypeAdvantage();

            Console.ReadKey();
        }
    }
}
