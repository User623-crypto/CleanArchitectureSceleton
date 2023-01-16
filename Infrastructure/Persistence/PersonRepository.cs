using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class PersonRepository : IPersonRepository
    {
        public readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context) { _context = context; }
        public async Task AddAsync(Person person)
        {
             _context.People.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var person = await _context.People.FindAsync(id);
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }

        public async Task<Person> GetById(int Id)
        {
            return await _context.People.FindAsync(Id);
        }

        public async Task<IEnumerable<Person>> ListPersonsAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            _context.People.Update(person);
            await _context.SaveChangesAsync();
        }
    }
}
