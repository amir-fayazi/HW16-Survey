
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Entities;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }
        public Person? GetByUsername(string username)
        {
            return _context.Persons.SingleOrDefault(x => x.Username == username);
        }


    }
}
