namespace RefBook.Application.DTOs
{
    public class RequestCreateUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public DateTime createAt { get; set; }
    }

    public class ResponseUser
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
    }

    public class UpdateUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
    }
}
