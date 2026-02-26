namespace MyProject.Model
{
    public class Listing
    {
        public int ListingId { get; set; }
        public int CreatorId { get; set; }
        public int PokemonId { get; set; }
        public string? ListingIMG { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public int Views { get; set; }
        public DateTime UploadDate { get; set; }
        public Pokemon Pokemon { get;set; }

    }
}
