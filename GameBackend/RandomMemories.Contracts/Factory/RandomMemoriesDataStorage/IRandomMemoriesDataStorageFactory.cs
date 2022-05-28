namespace RandomMemories.Contracts.Factory
{
    public interface IRandomMemoriesDataStorageFactory
    {
        IRandomMemoriesDataStorage CreateRandomMemoriesDataStorage(string imp);
    }
}
