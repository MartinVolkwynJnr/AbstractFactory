using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class PokemonWorld<T> : IPokemonWorld where T : IRegionFactory, new()
    {
        IFireType fireType;
        IWaterType waterType;
        IGrassType grassType;
        T factory;

        public PokemonWorld()
        {
            // Create new continent factory
            factory = new T();

            // Factory creates carnivores and herbivores
            waterType = factory.CreateWaterType();
            fireType = factory.CreateFireType();
            grassType = factory.CreateGrassType();
        }

        public void WhoHasTypeAdvantage()
        {
            waterType.Beats(fireType);
            fireType.Beats(grassType);
            grassType.Beats(waterType);
        }
    }
}
