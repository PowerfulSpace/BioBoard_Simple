using PS.BioBoard_Simple.Web.Models;

namespace PS.BioBoard_Simple.Web.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(Guid id);
        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Guid id);
    }
}
