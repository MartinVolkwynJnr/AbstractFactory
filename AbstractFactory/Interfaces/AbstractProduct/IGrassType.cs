namespace AbstractFactory.Interfaces
{
    public interface IGrassType
    {
        void Type(IGrassType h);
        void StrongAgaintsType(IGroundType h);
        void WeakAgainstType(IFireType h);
    }
}