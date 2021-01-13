using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Alola : IRegionFactory
    {
        public IFireType CreateFireType()
        {
            return new Litten();
        }

        public IGrassType CreateGrassType()
        {
            return new Rowlet();
        }

        public IWaterType CreateWaterType()
        {
            return new Popplio();
        }
    }
}
