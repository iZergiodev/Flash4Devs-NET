

using Flash4Devs_Backend.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<FlashCard> FlashCards { get; set; }
    public DbSet<CodingFlashcard> CodingFlashcards { get; set; }
    public DbSet<CustomFlashcard> CustomFlashcards { get; set; }
    public DbSet<InterviewQuestion> InterviewQuestions { get; set; }
}