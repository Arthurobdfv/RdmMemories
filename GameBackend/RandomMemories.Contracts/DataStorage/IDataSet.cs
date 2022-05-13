namespace RandomMemories.Contracts.DataStorage
{
    public interface IDataSet<T> where T : class
    {
        T GetById(object id);
        IEnumerable<T> GetAll();
        void Add(T item);
    }
}
