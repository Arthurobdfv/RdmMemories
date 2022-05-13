using RandomMemories.Contracts;
using RandomMemories.Contracts.Factory;
using RandomMemories.LocalImplementation.DataStorageImplementation;

namespace RandomMemories.FactoryImplementation
{
    public class RandomMemoriesDataStorageFactory : IRandomMemoriesDataStorageFactory
    {
        public RandomMemoriesDataStorageFactory()
        {

        }
        public IRandomMemoriesDataStorage CreateRandomMemoriesDataStorage(string imp)
        {
            return new RandomMemoriesLocalContext();
        }
    }
}
