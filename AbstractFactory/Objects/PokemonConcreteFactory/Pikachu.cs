using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Pikachu : IPokemonFactory
    {
        public IWaterType CreateHerbivore()
        {
            return new NormalType();
        }

        public IElectricType CreateCarnivore()
        {
            return new WaterType();
        }
    }
}
