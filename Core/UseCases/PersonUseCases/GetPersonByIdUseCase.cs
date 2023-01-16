using Core.Entities;
using Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.PersonUseCases
{
    public class GetPersonByIdUseCase
    {
        IPersonService service;
        public GetPersonByIdUseCase(IPersonService serviceProvider)
        {
            service = serviceProvider;
        }

        public async Task<Person> handle(int id)
        {
           return await service.getById(id);
        }
    }
}
