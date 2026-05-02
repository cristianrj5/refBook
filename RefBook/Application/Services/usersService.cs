using RefBook.Infrastructure.Repositories;
using RefBook.Application.Interfaces;
using RefBook.Domain.Entities;
namespace RefBook.Application.Services
{
    public class usersService : IUsersService
    {
        private readonly IUsersRespository _repo;  

        public usersService(IUsersRespository repo) { _repo = repo; }

        public Task Add(Users user)
        {
            return _repo.AddUser(user);
        }

        public Task Delete(int id)
        {
            return _repo.DeleteUsers(id);
        }

        public Task<IEnumerable<Users>> GetAll()
        {
            return _repo.GetAllUsers();
        }

        public Task<Users?> GetById(int id)
        {
            return _repo.GetUsersById(id);
        }

        public Task Update(int id, Users user)
        {
            return _repo.UpdateUsers(id, user);
        }
    }
}
