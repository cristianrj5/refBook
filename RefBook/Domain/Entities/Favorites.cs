namespace RefBook.Domain.Entities
{
    public class Favorites
    {
        public int idFavorite { get; set; }
        public int idUser {  get; set; }
        public string tipo { get; set; }
        public string  url { get; set; }
        public string description { get; set; }
        public string thumbnail { get; set; }
        public DateTime createAt { get; set; }
    }
}
