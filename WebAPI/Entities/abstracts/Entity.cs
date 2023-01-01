using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities.abstracts
{
    public abstract class Entity
    {
        [Key] 
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }
    }
}