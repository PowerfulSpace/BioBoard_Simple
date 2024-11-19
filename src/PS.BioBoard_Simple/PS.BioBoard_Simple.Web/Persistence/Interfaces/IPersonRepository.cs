using PS.BioBoard_Simple.Web.Models;

namespace PS.BioBoard_Simple.Web.Persistence.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(Guid id);
        Task<IEnumerable<Person>> GetAllAsync();

        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Guid id);
    }
}
