using Microsoft.AspNetCore.Mvc;
using RandomMemories.Contracts;
using RandomMemories.Domain;
using RandomMemories.SharedLibrary;
using RandomMemories.Contracts.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IRandomMemoriesDataStorage _storage;

        public PlayerController(IPlayerService playerSvc, IRandomMemoriesDataStorage storage)
        {
            _playerService = playerSvc;
            _storage = storage;
        }
        [HttpGet("{id}")]
        public Player Get([FromRoute] int id)
        {
            _playerService.DoSomething();
            return new Player()
            {
                Id = id,
                PlayerName = "Arthuro"
            };
        }

        [HttpGet]
        public IEnumerable<PlayerModel> GetAll()
        {
            return _storage.Players.GetAll();
        }

        [HttpPost]
        public void Post(Player plr)
        {
            _storage.Players.Add(new PlayerModel()
            {
                Id = plr.Id,
                Name = plr.PlayerName,
                Email = String.Empty
            });
        }
    }
}
