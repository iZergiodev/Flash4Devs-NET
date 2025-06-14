using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flash4Devs_Backend.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("email", TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        public string? Email { get; set; }

        [Column("name", TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Column("last_name", TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        public string? LastName { get; set; }

        [Column("role", TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string Role { get; set; } = "user";

        [Column("profile_image", TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        public string? ProfileImage { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relación uno a muchos con CustomFlashcard
        public ICollection<CustomFlashcard> CustomFlashcards { get; set; } = new List<CustomFlashcard>();

        [Column("good_answers")]
        public int GoodAnswers { get; set; } = 0;

        [Column("bad_answers")]
        public int BadAnswers { get; set; } = 0;

        [Column("level", TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string Level { get; set; } = "Beginner";

        [Column("rating_interview_front_react", TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string RatingInterviewFrontReact { get; set; } = "N/A";

        [Column("rating_interview_backend_python", TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string RatingInterviewBackendPython { get; set; } = "N/A";
    }
}