namespace Flash4Devs_Backend.DTO
{
    public class FlashcardCreateDto
    {
        public string Question { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Difficult { get; set; } = string.Empty;
    }
}
