using RefBook.Application.Interfaces;
using RefBook.Domain.Entities;
using RefBook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace RefBook.Infrastructure.Repositories
{
    public class UserRepository : IUsersRespository
    {

        private readonly AppData _context;

        public UserRepository(AppData context) {_context = context;}

        public async Task AddUser(Users user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUsers(int id)
        {
            var user = await _context.users.FindAsync(id);

            if (user == null) return;

            _context.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await _context.users.ToListAsync();
        }

        public async Task<Users?> GetUsersById(int id)
        {
            return await _context.users.FirstOrDefaultAsync(u => u.id == id);
        }

        public  async Task UpdateUsers(int id, Users user)
        {
            var existeUser = await _context.users.FindAsync(id);

            if (existeUser == null) return;

            existeUser.name = user.name;
            existeUser.email = user.email;
            existeUser.password_hash = user.password_hash;
        }
    }
}
