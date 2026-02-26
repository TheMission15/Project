using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyProject.Model;

namespace MyProject.Context
{
    public class DatabaseSeeder
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<Account> _userManager;
        public DatabaseSeeder(DatabaseContext context, UserManager<Account> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task Seed()
        {
            await _context.Database.MigrateAsync();

            if (!_context.Pokemons.Any())
            {
                var pokemons = GetPokemon();
                _context.Pokemons.AddRange(pokemons);
                await _context!.SaveChangesAsync();
            }

            if (!_context.Users.Any())
            {
                var Password = "Password1!";

                var user = new Account
                {
                    UserName = "Mission",
                    Email = "raul@gmail.com",
                    ProfilePicture = "main.png",
                    NumberOfListings = 0
                };
                await _userManager.CreateAsync(user, Password);
            }

                if (!_context.Listings.Any())
                {
                    var listings = GetListing();
                    _context.Listings.AddRange(listings);
                    await _context!.SaveChangesAsync();
                }

                if (!_context.Messages.Any())
                {
                    var messages = GetMessage();
                    _context.Messages.AddRange(messages);
                    await _context!.SaveChangesAsync();
                }

            
        }
        private List<Listing> GetListing()
        {
            return
            [
                new Listing
        {
            CreatorId = 1,
            PokemonId = 25,
            ListingIMG = "https://upload.wikimedia.org/wikipedia/en/a/a6/Pok%C3%A9mon_Pikachu_art.png",
            Price = 45.99,
            Description = "Well-trained Pikachu with solid stats. Friendly and reliable.",
            Views = 0,
            UploadDate = DateTime.UtcNow.AddDays(-2)
        },
        new Listing
        {
            CreatorId = 1,
            PokemonId = 151,
            ListingIMG = "https://upload.wikimedia.org/wikipedia/en/a/a6/Pok%C3%A9mon_Pikachu_art.png",
            Price = 45.99,
            Description = "just a pokemon i caught the other day",
            Views = 0,
            UploadDate = DateTime.UtcNow.AddDays(-2)
        },
            ];
        }
        private List<Message> GetMessage()
        {
            return
            [

            ];
        }
        private List<Pokemon> GetPokemon()
        {
            return
            [
        new Pokemon { Name = "Bulbasaur",     Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Ivysaur",       Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Venusaur",      Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },

        new Pokemon { Name = "Charmander",    Type1 = PokemonType.Fire },
        new Pokemon { Name = "Charmeleon",    Type1 = PokemonType.Fire },
        new Pokemon { Name = "Charizard",     Type1 = PokemonType.Fire,    Type2 = PokemonType.Flying },

        new Pokemon { Name = "Squirtle",      Type1 = PokemonType.Water },
        new Pokemon { Name = "Wartortle",     Type1 = PokemonType.Water },
        new Pokemon { Name = "Blastoise",     Type1 = PokemonType.Water },

        new Pokemon { Name = "Caterpie",      Type1 = PokemonType.Bug },
        new Pokemon { Name = "Metapod",       Type1 = PokemonType.Bug },
        new Pokemon { Name = "Butterfree",    Type1 = PokemonType.Bug,     Type2 = PokemonType.Flying },

        new Pokemon { Name = "Weedle",        Type1 = PokemonType.Bug,     Type2 = PokemonType.Poison },
        new Pokemon { Name = "Kakuna",        Type1 = PokemonType.Bug,     Type2 = PokemonType.Poison },
        new Pokemon { Name = "Beedrill",      Type1 = PokemonType.Bug,     Type2 = PokemonType.Poison },

        new Pokemon { Name = "Pidgey",        Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },
        new Pokemon { Name = "Pidgeotto",     Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },
        new Pokemon { Name = "Pidgeot",       Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Rattata",       Type1 = PokemonType.Normal },
        new Pokemon { Name = "Raticate",      Type1 = PokemonType.Normal },

        new Pokemon { Name = "Spearow",       Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },
        new Pokemon { Name = "Fearow",        Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Ekans",         Type1 = PokemonType.Poison },
        new Pokemon { Name = "Arbok",         Type1 = PokemonType.Poison },

        new Pokemon { Name = "Pikachu",       Type1 = PokemonType.Electric },
        new Pokemon { Name = "Raichu",        Type1 = PokemonType.Electric },

        new Pokemon { Name = "Sandshrew",     Type1 = PokemonType.Ground },
        new Pokemon { Name = "Sandslash",     Type1 = PokemonType.Ground },

        new Pokemon { Name = "Nidoran♀",      Type1 = PokemonType.Poison },
        new Pokemon { Name = "Nidorina",      Type1 = PokemonType.Poison },
        new Pokemon { Name = "Nidoqueen",     Type1 = PokemonType.Poison,  Type2 = PokemonType.Ground },

        new Pokemon { Name = "Nidoran♂",      Type1 = PokemonType.Poison },
        new Pokemon { Name = "Nidorino",      Type1 = PokemonType.Poison },
        new Pokemon { Name = "Nidoking",      Type1 = PokemonType.Poison,  Type2 = PokemonType.Ground },

        new Pokemon { Name = "Clefairy",      Type1 = PokemonType.Fairy },
        new Pokemon { Name = "Clefable",      Type1 = PokemonType.Fairy },

        new Pokemon { Name = "Vulpix",        Type1 = PokemonType.Fire },
        new Pokemon { Name = "Ninetales",     Type1 = PokemonType.Fire },

        new Pokemon { Name = "Jigglypuff",    Type1 = PokemonType.Normal,  Type2 = PokemonType.Fairy },
        new Pokemon { Name = "Wigglytuff",    Type1 = PokemonType.Normal,  Type2 = PokemonType.Fairy },

        new Pokemon { Name = "Zubat",         Type1 = PokemonType.Poison,  Type2 = PokemonType.Flying },
        new Pokemon { Name = "Golbat",        Type1 = PokemonType.Poison,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Oddish",        Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Gloom",         Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Vileplume",     Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },

        new Pokemon { Name = "Paras",         Type1 = PokemonType.Bug,     Type2 = PokemonType.Grass },
        new Pokemon { Name = "Parasect",      Type1 = PokemonType.Bug,     Type2 = PokemonType.Grass },

        new Pokemon { Name = "Venonat",       Type1 = PokemonType.Bug,     Type2 = PokemonType.Poison },
        new Pokemon { Name = "Venomoth",      Type1 = PokemonType.Bug,     Type2 = PokemonType.Poison },

        new Pokemon { Name = "Diglett",       Type1 = PokemonType.Ground },
        new Pokemon { Name = "Dugtrio",       Type1 = PokemonType.Ground },

        new Pokemon { Name = "Meowth",        Type1 = PokemonType.Normal },
        new Pokemon { Name = "Persian",       Type1 = PokemonType.Normal },

        new Pokemon { Name = "Psyduck",       Type1 = PokemonType.Water },
        new Pokemon { Name = "Golduck",       Type1 = PokemonType.Water },

        new Pokemon { Name = "Mankey",        Type1 = PokemonType.Fighting },
        new Pokemon { Name = "Primeape",      Type1 = PokemonType.Fighting },

        new Pokemon { Name = "Growlithe",     Type1 = PokemonType.Fire },
        new Pokemon { Name = "Arcanine",      Type1 = PokemonType.Fire },

        new Pokemon { Name = "Poliwag",       Type1 = PokemonType.Water },
        new Pokemon { Name = "Poliwhirl",     Type1 = PokemonType.Water },
        new Pokemon { Name = "Poliwrath",     Type1 = PokemonType.Water,   Type2 = PokemonType.Fighting },

        new Pokemon { Name = "Abra",          Type1 = PokemonType.Psychic },
        new Pokemon { Name = "Kadabra",       Type1 = PokemonType.Psychic },
        new Pokemon { Name = "Alakazam",      Type1 = PokemonType.Psychic },

        new Pokemon { Name = "Machop",        Type1 = PokemonType.Fighting },
        new Pokemon { Name = "Machoke",       Type1 = PokemonType.Fighting },
        new Pokemon { Name = "Machamp",       Type1 = PokemonType.Fighting },

        new Pokemon { Name = "Bellsprout",    Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Weepinbell",    Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Victreebel",    Type1 = PokemonType.Grass,   Type2 = PokemonType.Poison },

        new Pokemon { Name = "Tentacool",     Type1 = PokemonType.Water,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Tentacruel",    Type1 = PokemonType.Water,   Type2 = PokemonType.Poison },

        new Pokemon { Name = "Geodude",       Type1 = PokemonType.Rock,    Type2 = PokemonType.Ground },
        new Pokemon { Name = "Graveler",      Type1 = PokemonType.Rock,    Type2 = PokemonType.Ground },
        new Pokemon { Name = "Golem",         Type1 = PokemonType.Rock,    Type2 = PokemonType.Ground },

        new Pokemon { Name = "Ponyta",        Type1 = PokemonType.Fire },
        new Pokemon { Name = "Rapidash",      Type1 = PokemonType.Fire },

        new Pokemon { Name = "Slowpoke",      Type1 = PokemonType.Water,   Type2 = PokemonType.Psychic },
        new Pokemon { Name = "Slowbro",       Type1 = PokemonType.Water,   Type2 = PokemonType.Psychic },

        new Pokemon { Name = "Magnemite",     Type1 = PokemonType.Electric, Type2 = PokemonType.Steel },
        new Pokemon { Name = "Magneton",      Type1 = PokemonType.Electric, Type2 = PokemonType.Steel },

        new Pokemon { Name = "Farfetch’d",    Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Doduo",         Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },
        new Pokemon { Name = "Dodrio",        Type1 = PokemonType.Normal,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Seel",          Type1 = PokemonType.Water },
        new Pokemon { Name = "Dewgong",       Type1 = PokemonType.Water,   Type2 = PokemonType.Ice },

        new Pokemon { Name = "Grimer",        Type1 = PokemonType.Poison },
        new Pokemon { Name = "Muk",           Type1 = PokemonType.Poison },

        new Pokemon { Name = "Shellder",      Type1 = PokemonType.Water },
        new Pokemon { Name = "Cloyster",      Type1 = PokemonType.Water,   Type2 = PokemonType.Ice },

        new Pokemon { Name = "Gastly",        Type1 = PokemonType.Ghost,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Haunter",       Type1 = PokemonType.Ghost,   Type2 = PokemonType.Poison },
        new Pokemon { Name = "Gengar",        Type1 = PokemonType.Ghost,   Type2 = PokemonType.Poison },

        new Pokemon { Name = "Onix",          Type1 = PokemonType.Rock,    Type2 = PokemonType.Ground },

        new Pokemon { Name = "Drowzee",       Type1 = PokemonType.Psychic },
        new Pokemon { Name = "Hypno",         Type1 = PokemonType.Psychic },

        new Pokemon { Name = "Krabby",        Type1 = PokemonType.Water },
        new Pokemon { Name = "Kingler",       Type1 = PokemonType.Water },

        new Pokemon { Name = "Voltorb",       Type1 = PokemonType.Electric },
        new Pokemon { Name = "Electrode",     Type1 = PokemonType.Electric },

        new Pokemon { Name = "Exeggcute",     Type1 = PokemonType.Grass,   Type2 = PokemonType.Psychic },
        new Pokemon { Name = "Exeggutor",     Type1 = PokemonType.Grass,   Type2 = PokemonType.Psychic },

        new Pokemon { Name = "Cubone",        Type1 = PokemonType.Ground },
        new Pokemon { Name = "Marowak",       Type1 = PokemonType.Ground },

        new Pokemon { Name = "Hitmonlee",     Type1 = PokemonType.Fighting },
        new Pokemon { Name = "Hitmonchan",    Type1 = PokemonType.Fighting },

        new Pokemon { Name = "Lickitung",     Type1 = PokemonType.Normal },

        new Pokemon { Name = "Koffing",       Type1 = PokemonType.Poison },
        new Pokemon { Name = "Weezing",       Type1 = PokemonType.Poison },

        new Pokemon { Name = "Rhyhorn",       Type1 = PokemonType.Ground,  Type2 = PokemonType.Rock },
        new Pokemon { Name = "Rhydon",        Type1 = PokemonType.Ground,  Type2 = PokemonType.Rock },

        new Pokemon { Name = "Chansey",       Type1 = PokemonType.Normal },

        new Pokemon { Name = "Tangela",       Type1 = PokemonType.Grass },

        new Pokemon { Name = "Kangaskhan",    Type1 = PokemonType.Normal },

        new Pokemon { Name = "Horsea",        Type1 = PokemonType.Water },
        new Pokemon { Name = "Seadra",        Type1 = PokemonType.Water },

        new Pokemon { Name = "Goldeen",       Type1 = PokemonType.Water },
        new Pokemon { Name = "Seaking",       Type1 = PokemonType.Water },

        new Pokemon { Name = "Staryu",        Type1 = PokemonType.Water },
        new Pokemon { Name = "Starmie",       Type1 = PokemonType.Water,   Type2 = PokemonType.Psychic },

        new Pokemon { Name = "Mr. Mime",      Type1 = PokemonType.Psychic, Type2 = PokemonType.Fairy },

        new Pokemon { Name = "Scyther",       Type1 = PokemonType.Bug,     Type2 = PokemonType.Flying },

        new Pokemon { Name = "Jynx",          Type1 = PokemonType.Ice,     Type2 = PokemonType.Psychic },

        new Pokemon { Name = "Electabuzz",    Type1 = PokemonType.Electric },
        new Pokemon { Name = "Magmar",        Type1 = PokemonType.Fire },

        new Pokemon { Name = "Pinsir",        Type1 = PokemonType.Bug },
        new Pokemon { Name = "Tauros",        Type1 = PokemonType.Normal },

        new Pokemon { Name = "Magikarp",      Type1 = PokemonType.Water },
        new Pokemon { Name = "Gyarados",      Type1 = PokemonType.Water,   Type2 = PokemonType.Flying },

        new Pokemon { Name = "Lapras",        Type1 = PokemonType.Water,   Type2 = PokemonType.Ice },

        new Pokemon { Name = "Ditto",         Type1 = PokemonType.Normal },

        new Pokemon { Name = "Eevee",         Type1 = PokemonType.Normal },
        new Pokemon { Name = "Vaporeon",      Type1 = PokemonType.Water },
        new Pokemon { Name = "Jolteon",       Type1 = PokemonType.Electric },
        new Pokemon { Name = "Flareon",       Type1 = PokemonType.Fire },

        new Pokemon { Name = "Porygon",       Type1 = PokemonType.Normal },

        new Pokemon { Name = "Omanyte",       Type1 = PokemonType.Rock,    Type2 = PokemonType.Water },
        new Pokemon { Name = "Omastar",       Type1 = PokemonType.Rock,    Type2 = PokemonType.Water },

        new Pokemon { Name = "Kabuto",        Type1 = PokemonType.Rock,    Type2 = PokemonType.Water },
        new Pokemon { Name = "Kabutops",      Type1 = PokemonType.Rock,    Type2 = PokemonType.Water },

        new Pokemon { Name = "Aerodactyl",    Type1 = PokemonType.Rock,    Type2 = PokemonType.Flying },

        new Pokemon { Name = "Snorlax",       Type1 = PokemonType.Normal },

        new Pokemon { Name = "Articuno",      Type1 = PokemonType.Ice,     Type2 = PokemonType.Flying },
        new Pokemon { Name = "Zapdos",        Type1 = PokemonType.Electric,Type2 = PokemonType.Flying },
        new Pokemon { Name = "Moltres",       Type1 = PokemonType.Fire,    Type2 = PokemonType.Flying },

        new Pokemon { Name = "Dratini",       Type1 = PokemonType.Dragon },
        new Pokemon { Name = "Dragonair",     Type1 = PokemonType.Dragon },
        new Pokemon { Name = "Dragonite",     Type1 = PokemonType.Dragon,  Type2 = PokemonType.Flying },

        new Pokemon { Name = "Mewtwo",        Type1 = PokemonType.Psychic },
        new Pokemon { Name = "Mew",           Type1 = PokemonType.Psychic }
            ];
        }

    }
}
