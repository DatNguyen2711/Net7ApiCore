namespace Net7CoreAPIFULL.Services.SuperHeroService
{
    public interface ISuperHeroService
    {

        Task<List<Superhero>> GetAllHeroes();
        Task<Superhero?> GetSingleHeroes(int id);
        Task<List<Superhero>> AddHero(Superhero superhero);
        Task<List<Superhero>?> UpdateHero(int id, Superhero request);
        Task<List<Superhero>?> Deleteahero(int id);
    }
}
