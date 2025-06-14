using Flash4Devs_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flash4Devs_Backend.Repositories
{
    public class FlashcardRepository : IFlashcardRepository
    {
        private readonly ApplicationDbContext _context;

        public FlashcardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FlashCard>> GetAllAsync()
        {
            return await _context.FlashCards.ToListAsync();
        }

        public async Task<FlashCard?> GetByIdAsync(int id)
        {
            return await _context.FlashCards.FindAsync(id);
        }

        public async Task AddAsync(FlashCard flashCard)
        {
            await _context.FlashCards.AddAsync(flashCard);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(FlashCard flashCard)
        {
            _context.FlashCards.Update(flashCard);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var flashCard = await _context.FlashCards.FindAsync(id);
            if (flashCard != null)
            {
                _context.FlashCards.Remove(flashCard);
                await _context.SaveChangesAsync();
            }
        }
    }
}
