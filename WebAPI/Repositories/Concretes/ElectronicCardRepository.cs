using WebAPI.Data;
using WebAPI.Entities;
using WebAPI.Repositories.Abstracts;

namespace WebAPI.Repositories.Concretes
{
    public class ElectronicCardRepository : IElectronicCardRepository
    {
        private readonly AppDbContext _context;

        public ElectronicCardRepository(AppDbContext context)
        {
            _context = context;
        }

        public ElectronicCard? Add(ElectronicCard electronic)
        {
            var addedCard = _context.ElectronicCards?.Add(electronic).Entity;
            _context.SaveChanges();
            return addedCard;
        }

        public ElectronicCard? Update(ElectronicCard electronic)
        {
            var updatedCard = _context.ElectronicCards?.Update(electronic).Entity;
            _context.SaveChanges();
            return updatedCard;
        }

        public ElectronicCard? GetCardByUuid(string uuid)
        {
            var card = _context.ElectronicCards?.FirstOrDefault(t => t.Uuid == uuid);
            return card;
        }

        public List<ElectronicCard>? GetAll()
        {
            return _context.ElectronicCards?.ToList();
        }
    }
}