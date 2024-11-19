﻿using PS.BioBoard_Simple.Web.Models;
using PS.BioBoard_Simple.Web.Persistence.Interfaces;

namespace PS.BioBoard_Simple.Web.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetByIdAsync(Guid id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Person person)
        {
            // Дополнительная бизнес-логика перед добавлением
            await _personRepository.AddAsync(person);
        }

        public async Task UpdateAsync(Person person)
        {
            // Дополнительная бизнес-логика перед обновлением
            await _personRepository.UpdateAsync(person);
        }

        public async Task DeleteAsync(Guid id)
        {
            // Дополнительная бизнес-логика перед удалением
            await _personRepository.DeleteAsync(id);
        }
    }
}
