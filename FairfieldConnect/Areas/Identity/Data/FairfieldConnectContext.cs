using FairfieldConnect.Areas.Identity.Data;
using FairfieldConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FairfieldConnect.Data;

public class FairfieldConnectContext : IdentityDbContext<FairfieldConnectUser>
{
    public FairfieldConnectContext(DbContextOptions<FairfieldConnectContext> options)
        : base(options)
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
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
