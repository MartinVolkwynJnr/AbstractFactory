namespace AbstractFactory.Interfaces
{
    public interface IRegionFactory
    {
        IFireType CreateFireType();
        IWaterType CreateWaterType();
        IGrassType CreateGrassType();
    }
}