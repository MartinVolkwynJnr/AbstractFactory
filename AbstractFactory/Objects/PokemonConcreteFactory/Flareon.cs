using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Africa : IPokemonFactory
    {
        public IWaterType CreateHerbivore()
        {
            return new Wildebees();
        }

        public IElectricType CreateCarnivore()
        {
            return new Lion();
        }
    }
}
