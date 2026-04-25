using System.ComponentModel.DataAnnotations;

namespace RefBook.Domain.Entities
{
    public class Users
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public DateTime createAt { get; set; }
    }
}
