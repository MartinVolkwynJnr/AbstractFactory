namespace AbstractFactory.Interfaces
{
    public interface IWaterType
    {
        void Type(IWaterType h);
        void StrongAgaintsType(IFireType h);
        void WeakAgainstType(IGrassType h);
    }
}