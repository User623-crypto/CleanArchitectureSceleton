using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.IServices;

namespace Infrastructure.Services
{
    public class PersonService : IPersonService
    {
        IPersonRepository _repo;
        public PersonService(IPersonRepository repo) { _repo = repo; }

        public async Task<IEnumerable<Person>> getAllPeople()
        {
            return await _repo.ListPersonsAsync();
        }

        public async Task<Person> getById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Person> getByName(string name)
        {
            var people =  await _repo.ListPersonsAsync();
            return people.Where(e => e.Name.Equals(name)).FirstOrDefault();
        }

        public async Task updatePerson(Person person)
        {
             await _repo.UpdateAsync(person);
        }
    }
}
