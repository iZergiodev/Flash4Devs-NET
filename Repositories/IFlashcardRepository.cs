using Flash4Devs_Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flash4Devs_Backend.Repositories
{
    public interface IFlashcardRepository
    {
        Task<IEnumerable<FlashCard>> GetAllAsync();
        Task<FlashCard?> GetByIdAsync(int id);
        Task AddAsync(FlashCard flashcard);
        Task UpdateAsync(FlashCard flashcard);
        Task DeleteAsync(int id);
    }
}
