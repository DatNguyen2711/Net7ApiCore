using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net7CoreAPIFULL.Models;
using Net7CoreAPIFULL.Services.SuperHeroService;

namespace Net7CoreAPIFULL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperheroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;

        }
        [HttpGet]
        public async Task<ActionResult<List<Superhero>>> GetAllHeroes()
        {
            return await _superHeroService.GetAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Superhero>> GetSingleHeroes(int id)
        {
            var res = await _superHeroService.GetSingleHeroes(id);
            if (res is null)
            {
                return NotFound("đéo có thằng đấy ở đây ");
            }
            return Ok(res);
        }

        [HttpPost]
        public async Task<ActionResult<List<Superhero>>> AddHero(Superhero superhero)
        {
            var res = await _superHeroService.AddHero(superhero);
            return Ok(res);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Superhero>>> UpdateHero(int id, Superhero request)
        {
            var res = await _superHeroService.UpdateHero(id, request);
            if (res is null)
            {
                return NotFound("đéo có thằng đấy ở đây ");
            }
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Superhero>>> Deleteahero(int id)
        {
            var res = await _superHeroService.Deleteahero(id);
            if (res is null)
            {
                return NotFound("đéo có thằng đấy ở đây ");
            }
            return Ok(res);

        }
    }
}
