namespace smartography.BLL.Factories
{
    public abstract class ObjectFactory<T>
    {
        public abstract T Create(string row);
    }
}
