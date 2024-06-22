using Microsoft.AspNetCore.Components.Authorization;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Models.Interfaces
{
    public interface ILibraryService
    {
        public Task<List<Book>?> GetBooks();
        public Task DeleteBook(Book book);
        public Task AddBook(Book book);
        public Task UpdateBook(Book book);
        public Task CheckoutBook(Book book);
        public Task CheckInBook(Book book);
    }
}
