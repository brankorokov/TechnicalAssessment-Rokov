using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessmentRokov.Entities
{
    public class Book
    {
        
        public int ID { get; set; }
        public int ISBN { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public byte[]? CoverPage { get; set; }
        public string? Publisher { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string? Category { get; set; }
        public int PageCount { get; set; }

    }
    
}
