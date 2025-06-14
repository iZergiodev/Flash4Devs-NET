using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flash4Devs_Backend.Models
{
    [Table("interview_questions")]
    public class InterviewQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("question")]
        public string Question { get; set; } = string.Empty;

        [Required]
        [Column("technology")]
        public string Technology { get; set; } = string.Empty; // "frontendreact" o "backendpython"
    }
}
