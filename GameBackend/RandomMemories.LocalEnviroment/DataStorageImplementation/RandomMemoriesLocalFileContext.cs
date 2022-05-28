using RandomMemories.Contracts;
using RandomMemories.Contracts.DataStorage;
using RandomMemories.Contracts.Models;

namespace RandomMemories.LocalImplementation.DataStorageImplementation
{
    public class RandomMemoriesLocalFileContext : IRandomMemoriesDataStorage
    {
        public RandomMemoriesLocalFileContext()
        {
            Players = new LocalFileDataSet<PlayerModel>();
        }
        public IDataSet<PlayerModel> Players { get; set; }
    }
}
