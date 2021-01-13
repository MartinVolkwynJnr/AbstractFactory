using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Indigo : IRegionFactory
    {
        public IFireType CreateFireType()
        {
            return new Flareon();
        }

        public IGrassType CreateGrassType()
        {
            return new Leafeon();
        }

        public IWaterType CreateWaterType()
        {
            return new Vaporeon();
        }
    }
}
