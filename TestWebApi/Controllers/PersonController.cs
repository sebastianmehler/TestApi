using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.Model;
using TestWebApi.Services;

namespace TestWebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PersonController : ControllerBase
  {
    public PersonController(IPersonService service)
    {
      Service = service;
    }

    public IPersonService Service { get;  }

    [HttpGet]
    public IEnumerable<Person> GetPersons() => Service.GetPersons();

    [HttpPost]
    public void AddPerson([FromBody] Person person) => Service.AddPerson(person);
  }
}
