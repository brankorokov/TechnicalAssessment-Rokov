using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Xml;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<IdentityUser>(options)
    {

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>(b =>
            {

                //Wont need these properties for this project
                b.Ignore(c => c.AccessFailedCount)
                 .Ignore(c => c.TwoFactorEnabled)
                 .Ignore(c => c.ConcurrencyStamp)
                 .Ignore(c => c.Email)
                 .Ignore(c => c.NormalizedEmail)
                 .Ignore(c => c.EmailConfirmed)
                 .Ignore(c => c.SecurityStamp)
                 .Ignore(c => c.ConcurrencyStamp)
                 .Ignore(c => c.PhoneNumber)
                 .Ignore(c => c.PhoneNumberConfirmed)
                 .Ignore(c => c.TwoFactorEnabled)
                 .Ignore(c => c.AccessFailedCount)
                 .Ignore(c => c.LockoutEnabled)
                 .Ignore(c => c.LockoutEnd);

            });

            var ids = 1;

            var bookFaker = new Faker<Book>()
                .RuleFor(m => m.ID, faker => ids++)
                .RuleFor(m => m.ISBN, faker => faker.Random.Int(100000000, 999999999))
                .RuleFor(m => m.Author, faker => faker.Name.FullName())
                .RuleFor(m => m.Description, faker => faker.Lorem.Sentence(20))
                .RuleFor(m => m.CoverPage, faker => faker.Image.PicsumUrl(width: 50, height: 50))
                .RuleFor(m => m.Publisher, faker => faker.Company.CompanyName())
                .RuleFor(m => m.PublicationDate, faker => faker.Date.Past().Date)
                .RuleFor(m => m.Category, faker => faker.Lorem.Word())
                .RuleFor(m => m.PageCount, faker => faker.Random.Int(min: 50, max: 999))
                .RuleFor(m => m.Title, faker => faker.Random.Words(3))
                .RuleFor(m => m.CheckedOutDate, faker => null)
                .RuleFor(m => m.DueDate, faker => null)
                .RuleFor(m => m.CheckedOutByUserId, faker => null);


            builder.Entity<Book>(b =>
            {
                b.HasData(bookFaker.Generate(100));
            });

            base.OnModelCreating(builder);
        }
    }
}
