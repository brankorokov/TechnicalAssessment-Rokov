using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ids = 1;

            //Seeding with Bogus
            var book = new Faker<Book>()
                .RuleFor(m => m.ID, faker => ids++)
                .RuleFor(m => m.ISBN, faker => faker.Random.Int(100000000, 999999999))
                .RuleFor(m => m.Author, faker => faker.Name.FullName())
                .RuleFor(m => m.Description, faker => faker.Lorem.Sentence(20))
                .RuleFor(m => m.CoverPage, faker => faker.Image.PicsumUrl(width: 50, height: 50))
                .RuleFor(m => m.Publisher, faker => faker.Company.CompanyName())
                .RuleFor(m => m.PublicationDate, faker => faker.Date.Past().Date)
                .RuleFor(m => m.Category, faker => faker.Lorem.Word())
                .RuleFor(m => m.PageCount, faker => faker.Random.Int(min: 50, max: 999))
                .RuleFor(m => m.Title, faker => faker.Random.Words(3));

            builder.Entity<Book>().HasData(book.Generate(100));
        }
    }
}
