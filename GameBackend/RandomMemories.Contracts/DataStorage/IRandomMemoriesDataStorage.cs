using RandomMemories.Contracts.DataStorage;
using RandomMemories.Contracts.Models;

namespace RandomMemories.Contracts
{
    public interface IRandomMemoriesDataStorage
    {
        IDataSet<PlayerModel> Players { get; set; }
    }
}
