namespace AbstractFactory.Interfaces
{
    public interface INormalType
    {
        void Type(INormalType h);
        void StrongAgaintsType();
        void WeakAgainstType(IGrassType h);
    }
}