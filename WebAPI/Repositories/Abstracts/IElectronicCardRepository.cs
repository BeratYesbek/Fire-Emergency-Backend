using WebAPI.Entities;

namespace WebAPI.Repositories.Abstracts
{
    public interface IElectronicCardRepository
    {
        ElectronicCard? Add(ElectronicCard electronic);

        ElectronicCard? Update(ElectronicCard electronic);

        ElectronicCard? GetCardByUuid(string uuid);

        List<ElectronicCard>? GetAll();
    }
}