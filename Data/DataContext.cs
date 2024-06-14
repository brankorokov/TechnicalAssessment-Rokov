using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
