using FairfieldConnect.Areas.Identity.Data;
using FairfieldConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FairfieldConnect.Data;

public class FairfieldConnectContext : IdentityDbContext<FairfieldConnectUser>
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public FairfieldConnectContext(DbContextOptions<FairfieldConnectContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
        builder.Entity<TutoringPost>().HasData(
            new TutoringPost
            {
                TutoringPostID = 1,
                Title = "Look for tutoring",
                Desc = "I need a tutor who is free on Monday afternoon",
                Subject = "Math",
                Rate = 15,
                StudentID = 3,
                CategoryID = 2,
            }
        );
        builder.Entity<Club>().HasData(
            new Club
            {
                ClubID = 1,
                Name = "Fairfield Student Association",
                Desc = "Connect Stags",
                StudentID = 3,
                CategoryID = 3,
            }
        );
        builder.Entity<Event>().HasData(
            new Event
            {
                EventID = 1,
                Title = "Career Fair 2022",
                Desc = "Opportunity to meet potential employers to expand networking",
                Location = "Kelly Center, room 203",
                Hosting = new DateTime(2022, 05, 15, 15,00,00),
                ClubID = 1,
            }
        );
        builder.Entity<SellPost>().HasData(
            new SellPost
            {
                SellPostID = 1,
                Title = "Have a new laptop",
                Desc = "Dell Inspiron 2022, intel core i7",
                Price = 1000,
                Location = "pick up at lower level BCC",
                StudentID = 4,
                CategoryID = 4,
            }
        );
        builder.Entity<ShopPost>().HasData(
            new ShopPost
            {
                ShopPostID = 1,
                Title = "Look for a macbook",
                Desc = "I am looking for an used Macbook",
                Price = 1000,
                StudentID = 4,
                CategoryID = 4,
            }
        );
        builder.Entity<Thumbnail>().HasData(
            new Thumbnail
            {
                ThumbnailID = 1,
                Title = "House",
                ThumbnailName= "House",
                ReviewID = 1
            }
        );

    }
}
