using System.ComponentModel.DataAnnotations;

namespace TechnicalAssessmentRokov.Models.ViewModels
{
    public class AddBookViewModel
    {
        public string? Title { get; set; } 
        public int? ISBN { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; } 
        public string? CoverPage { get; set; } 
        public string? Publisher { get; set; } 
        public DateTime? PublicationDate { get; set; } 
        public string? Category { get; set; }
        public int? PageCount { get; set; }
    }
}
