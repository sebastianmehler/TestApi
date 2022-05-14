using System.Collections.Generic;
using TestWebApi.Model;

namespace TestWebApi.Services
{
  public interface IPersonService
  {
    IEnumerable<Person> GetPersons();
    void AddPerson(Person person);
  }
}