using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechnicalAssessmentRokov.Entities
{
    public class Book
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }
        [Required]
        [Column("TITLE")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Column("ISBN")]
        public int ISBN { get; set; }
        [Column("AUTHOR")]
        public string? Author { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("COVER_PAGE")]
        public string? CoverPage { get; set; }
        [Column("PUBLISHER")]
        public string? Publisher { get; set; }
        [Column("PUBLICATION_DATE")]
        public DateTime? PublicationDate { get; set; }
        [Column("CATEGORY")]
        public string? Category { get; set; }
        [Column("PAGE_COUNT")]
        public int PageCount { get; set; }

    }
    
}
