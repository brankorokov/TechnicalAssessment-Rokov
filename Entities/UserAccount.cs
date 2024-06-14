using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalAssessmentRokov.Entities
{
    public class UserAccount
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("USER_NAME")]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Column("PASSWORD")]
        [MaxLength(100)]
        public string? Password { get; set; }

        [Column("ROLE")]
        [MaxLength(20)]
        public string? Role { get; set; }
    }
}
