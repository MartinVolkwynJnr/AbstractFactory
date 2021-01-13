namespace AbstractFactory.Interfaces
{
    public interface IPokemonFactory
    {
        IWaterType CreateType();
        IElectricType CreateStrongAgainstType();
        IElectricType CreateWeakAgainstType();
    }
}