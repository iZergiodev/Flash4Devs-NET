using Flash4Devs_Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flash4Devs_Backend.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
