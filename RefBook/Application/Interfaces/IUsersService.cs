using RefBook.Domain.Entities;

namespace RefBook.Application.Interfaces
{
    public interface IUsersService
    {
        Task<Users?> GetById(int id);
        Task<IEnumerable<Users>> GetAll();
        Task Add(Users user);
        Task Delete(int id);
        Task Update(int id, Users user);
    }
}
