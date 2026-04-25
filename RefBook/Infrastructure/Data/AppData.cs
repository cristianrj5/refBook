using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RefBook.Domain.Entities;

namespace RefBook.Infrastructure.Data
{
    public class AppData : DbContext
    {
        public AppData(DbContextOptions<AppData> options) :base (options){ } 

        public DbSet<Users> users { get; set; }

    }
}
