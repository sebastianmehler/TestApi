using System.Collections.Generic;
using TestWebApi.Model;

namespace TestWebApi.Services
{
  public interface IPersonCache
  {
    IEnumerable<Person> Persons { get; set; }
  }
}