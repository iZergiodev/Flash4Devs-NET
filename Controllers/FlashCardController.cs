using Flash4Devs_Backend.Models;
using Flash4Devs_Backend.DTO;
using Flash4Devs_Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flash4Devs_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlashCardController : ControllerBase
    {
        private readonly IFlashcardRepository _flashcardRepository;

        public FlashCardController(IFlashcardRepository flashcardRepository)
        {
            _flashcardRepository = flashcardRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlashCard>>> GetAll()
        {
            var flashcards = await _flashcardRepository.GetAllAsync();
            return Ok(flashcards);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FlashCard>> GetById(int id)
        {
            var flashcard = await _flashcardRepository.GetByIdAsync(id);
            if (flashcard == null) return NotFound();
            return Ok(flashcard);
        }

        [HttpPost]
        public async Task<ActionResult> Create(DTO.FlashcardCreateDto flashcardDto)
        {
            var flashcard = new FlashCard
            {
                Question = flashcardDto.Question,
                Category = flashcardDto.Category,
                Difficult = flashcardDto.Difficult
            };
            await _flashcardRepository.AddAsync(flashcard);
            return CreatedAtAction(nameof(GetById), new { id = flashcard.Id }, flashcard);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, FlashCard flashcard)
        {
            if (id != flashcard.Id) return BadRequest();
            await _flashcardRepository.UpdateAsync(flashcard);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _flashcardRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
