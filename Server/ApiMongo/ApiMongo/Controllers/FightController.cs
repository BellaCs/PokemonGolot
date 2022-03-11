using Microsoft.AspNetCore.Mvc;

namespace ApiMongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly ILogger<FightController> _logger;

        public FightController(ILogger<FightController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFight")]
        public IEnumerable<Fight> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Fight
            {
                Date = DateTime.Now.AddDays(index)
            })
            .ToArray();
        }
    }
}