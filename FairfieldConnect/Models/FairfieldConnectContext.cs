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
        public DbSet<Club>? Clubs { get; set; }
        public DbSet<Event>? Events { get; set; }
        public DbSet<HousingPost>? HousingPosts { get; set; }
        public DbSet<Landlord>? Landlords { get; set; }
        public DbSet<SellPost>? SellPosts { get; set; }
        public DbSet<ShopPost>? ShopPosts { get; set; }
        public DbSet<TutoringPost>? TutoringPosts { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Thumbnail>? Thumbnails { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        _ = builder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    Name = "Hien Tran",
                    Phone = "7346292088",
                    Email = "tranminhhien14@gmail.com",
                    Address = "104 S.Franklin Dr., Troy, AL"
                }
        );
    }
}
