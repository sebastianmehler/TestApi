using System.Collections.Generic;
using System.Security.AccessControl;
using TestWebApi.Model;

namespace TestWebApi.Services
{
  public class PersonCache : IPersonCache
  {
    public IEnumerable<Person> Persons { get; set; }
  }
}
