using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities.abstracts
{
    public interface IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
