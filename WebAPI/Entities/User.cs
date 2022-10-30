using WebAPI.Entities.abstracts;

namespace WebAPI.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? PhoneNumber { get; set; }
       /* public byte[]? PasswordSalt { get; set; }
        public byte[]? PasswordHash { get; set; }*/
        public virtual List<User>? Users { get; set; }
    }
}