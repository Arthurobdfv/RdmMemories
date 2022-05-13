using Microsoft.AspNetCore.Mvc;
using RandomMemories.Contracts;
using RandomMemories.Domain;
using RandomMemories.SharedLibrary;

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

        [HttpPost]
        public void Post(Player plr)
        {
            Console.WriteLine($"Player {plr.PlayerName} has been added to the DB");
        }
    }
}
