using WebAPI.Entities.abstracts;

namespace WebAPI.Entities
{
    public class Card : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
