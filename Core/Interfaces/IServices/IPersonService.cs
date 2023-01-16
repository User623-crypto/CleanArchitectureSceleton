using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IServices
{
    public interface IPersonService
    {
        public Task<IEnumerable<Person>> getAllPeople();
        public Task<Person> getByName(string name);
        public Task<Person> getById(int id);
        public Task updatePerson(Person person);

    }
}
