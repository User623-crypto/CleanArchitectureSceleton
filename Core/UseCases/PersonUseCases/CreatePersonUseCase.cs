using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
namespace Core.UseCases.PersonUseCases
{
    public class CreatePersonUseCase 
    {
        public readonly IPersonRepository _personRepository;

        public CreatePersonUseCase(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<Person> Handle(Person person)
        {
            await _personRepository.AddAsync(person);
            return person;
        }

       
    }
}
