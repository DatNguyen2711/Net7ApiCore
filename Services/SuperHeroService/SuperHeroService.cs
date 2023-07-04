using Net7CoreAPIFULL.Models;

namespace Net7CoreAPIFULL.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<Superhero> superheroes = new List<Superhero>();


        private readonly DataContext _context;
        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Superhero>> AddHero(Superhero superhero)
        {
            _context.Superheroes.Add(superhero);
            await _context.SaveChangesAsync();
            return await _context.Superheroes.ToListAsync();
        }

        public async Task<List<Superhero>?> Deleteahero(int id)
        {

            var hero = await _context.Superheroes.FindAsync(id);
            if (hero == null)
            {
                return null;
            }
            _context.Superheroes.Remove(hero);
            await _context.SaveChangesAsync();
            return await _context.Superheroes.ToListAsync();
        }

        public async Task<List<Superhero>>? GetAllHeroes()
        {
            var heroes = await _context.Superheroes.ToListAsync();
            return heroes;
        }

        public async Task<Superhero>? GetSingleHeroes(int id)
        {
            var hero = await _context.Superheroes.FindAsync(id);
            if (hero == null)
            {
                return null;
            }
            return hero;
        }

        public async Task<List<Superhero>?> UpdateHero(int id, Superhero request)
        {
            var hero = await _context.Superheroes.FindAsync(id);
            if (hero == null)
            {
                return null;
            }
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;
            await _context.SaveChangesAsync();
            return await _context.Superheroes.ToListAsync();
        }
    }
}
