using RandomMemories.Contracts;
using RandomMemories.Contracts.DataStorage;
using RandomMemories.Contracts.Models;

namespace RandomMemories.LocalImplementation.DataStorageImplementation
{
    public class RandomMemoriesLocalContext : IRandomMemoriesDataStorage
    {
        public RandomMemoriesLocalContext()
        {
            Players = new LocalFileDataSet<PlayerModel>(nameof(PlayerModel));
        }
        public IDataSet<PlayerModel> Players { get; set; }
    }
}
