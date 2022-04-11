using Microsoft.EntityFrameworkCore;

namespace FairfieldConnect.Models
{
    public class FairfieldConnectContext : DbContext
    {
        public FairfieldConnectContext(DbContextOptions<FairfieldConnectContext> options): base(options)
        { }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<HousingPost> HousingPosts { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<SellPost> SellPosts { get; set; }
        public DbSet<ShopPost> ShopPosts { get; set; }
        public DbSet<TutoringPost> TutoringPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Thumbnail> Thumbnails { get; set; }

    }
}
