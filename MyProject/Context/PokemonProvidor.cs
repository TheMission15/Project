using Microsoft.EntityFrameworkCore;
using MyProject.Model;

namespace MyProject.Context
{
    public class PokemonmProvider
    {
        public readonly DatabaseContext _context;
        public PokemonmProvider(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Pokemon>> GetAllPokemonAsync()
        {
            return await _context.Pokemons.OrderBy(pokemon => pokemon.PokemonId).ToListAsync();
        }
        public Pokemon? GetPokemon(int id)
        {
            return _context.Pokemons.Find(id);
        }
    }
}
