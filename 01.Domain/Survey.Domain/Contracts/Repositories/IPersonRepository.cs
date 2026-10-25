

using Survey.Domain.Entities;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IPersonRepository
    {

        Person? GetByUsername(string username);


    }
}
