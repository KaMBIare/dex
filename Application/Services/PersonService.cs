using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class PersonService
{
    public readonly IPersonRepository Repository;

    public Person GetById(Guid id)
    {
        return Repository.GetById(id);
        
    }

    public Person Create(Person person)
    {
        return Repository.Create(person);
    }
    public Person Update(Person person)
    {
        return Repository.Update(person);
    }
    public bool Delete(Guid id)
    {
        return Repository.Delete(id);
    }
}