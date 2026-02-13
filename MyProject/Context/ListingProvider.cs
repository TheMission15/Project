using MyProject.Model;

namespace MyProject.Context
{
    public class ListingProvider
    {
        public readonly DatabaseContext _context;
        public ListingProvider(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Listing>> GetAllListingsAsync()
        {
            return await _context.Listings.OrderBy(listing => listing.UploadDate).ToListAsync();
        }
        public Listing? GetListing(int id)
        {
            return _context.Listings.Find(id);
        }
    }
}
