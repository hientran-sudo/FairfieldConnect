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

        public DbSet<Review>? Reviews { get; set; }
        public DbSet<ListPost> ListPosts { get; set; }
        public DbSet<FindPost>? FindPosts { get; set; }
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
        builder.Entity<Category>().HasData(
            new Category
            {
                CategoryID = 1,
                Name = "Housing"
            },
            new Category
            {
                CategoryID = 2,
                Name = "Tutoring"
            },
            new Category
            {
                CategoryID = 3,
                Name = "Community"
            },
            new Category
            {
                CategoryID = 4,
                Name = "Market"
            }
                
        );
        builder.Entity<Student>().HasData(
            new Student
            {
                StudentID = 3,
                Name = "Hien Tran",
                Phone = "203 888 999",
                Email = "hientran@student.fairfield.edu",
                Dob = new DateTime(1997,08,08),
                Address = "104 S.Franklin Dr., Troy, AL 36081"
            },
            new Student
            {
                StudentID = 4,
                Name = "Thomas",
                Phone = "203 134 987",
                Email = "tom@student.fairfield.edu",
                Dob = new DateTime(1992, 04, 04),
                Address = "154 Oak st., Troy, AL 36081"
            }
        );
        builder.Entity<Landlord>().HasData(
            new Landlord
            {
                LandlordID = 1,
                Name = "Blue Key Properties",
                Phone = "203 194 936",
                Email = "bkp@gmail.com"
            },
            new Landlord
            {
                LandlordID = 2,
                Name = "Sand Rock",
                Phone = "203 134 098",
                Email = "sr@gmail.com"
            }           
        );
        builder.Entity<ListPost>().HasData(
            new ListPost
            {
                ListPostID = 1,
                Title = "Looking for a female roommate",
                Desc = "Clean and tidy bedroom in a townhouse, 1 mile to campus, 1.5 miles to the beach",
                Address = "100 N. River st., Fairfield, CT 06824",
                Rate = 800,
                StudentID = 3,
                CategoryID = 1,
                LandlordID = 1,
            }
        );
        
        builder.Entity<FindPost>().HasData(
            new FindPost
            {
                FindPostID = 1,
                Title = "Looking for a sublease apartment this FALL",
                Desc = "I am looking for an apartment/studio that is close to the train station",
                Location = "Fairfield, CT",
                Rate = 1000,
                StudentID = 4,
                CategoryID = 1,              
            }
        );
        builder.Entity<Review>().HasData(
            new Review
            {
                ReviewID = 1,
                Title = "Good customer service",
                Desc = "Landlord is very responsive and helpful!",
                Address = "apt at 15 University Corner, Fairfield",
                StudentID = 3,
                CategoryID = 1,
                LandlordID = 1,
            }
        );
    }
}
