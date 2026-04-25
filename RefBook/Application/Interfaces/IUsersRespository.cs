using RefBook.Domain.Entities;
using System.Data.SqlTypes;

namespace RefBook.Application.Interfaces
{
    public interface IUsersRespository
    {
        Task<Users?> GetUsersById(int id);
        Task<IEnumerable<Users>> GetAllUsers();
        Task AddUser (Users user);
        Task DeleteUsers(int id);
        Task UpdateUsers(int id, Users user);
    }
}
