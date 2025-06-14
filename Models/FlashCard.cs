using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flash4Devs_Backend.Models
{
    [Table("Flashcard")]
    public class FlashCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("question")]
        public string Question { get; set; } = string.Empty;

        [Required]
        [Column("category")]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Column("difficult")]
        [RegularExpression("^(easy|medium|hard)$", ErrorMessage = "Difficult solo puede ser 'easy', 'medium' o 'hard'.")]
        public string Difficult { get; set; } = string.Empty;
    }
}
