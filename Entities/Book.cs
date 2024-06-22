using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public DateTime? PublicationDate { get; set; }
        [Column("CATEGORY")]
        public string? Category { get; set; }
        [Column("PAGE_COUNT")]
        public int PageCount { get; set; }
        [Column("CHECKED_OUT_DATE")]
        public DateTime? CheckedOutDate { get; set; }
        [Column("DUE_DATE")]
        public DateTime? DueDate { get; set; }
        [ForeignKey("CheckedOutByUser")]
        public string? CheckedOutByUserId { get; set; }
        public virtual IdentityUser? CheckedOutByUser { get; set; }
    }
    
}
