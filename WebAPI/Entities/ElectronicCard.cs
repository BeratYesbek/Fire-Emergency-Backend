using WebAPI.Entities.abstracts;

namespace WebAPI.Entities
{
    public class ElectronicCard : Entity
    {

        public string? Uuid { get; set; }
        public string? QrCode { get; set; }
        
    }
}