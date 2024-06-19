﻿using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Models.Interfaces
{
    public interface IHomeService
    {
        public Task<List<Book>?> GetBooks();
        public Task DeleteBook(int bookId);
    }
}