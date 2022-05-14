using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TestWebApi.Model;

namespace TestWebApi.Services
{
  public class PersonService : IPersonService
  {
    public PersonService(IPersonCache cache)
    {
      Cache = cache;
      if (Persons==null)
      {
        Persons = LoadPersons().ToList();
      }
    }

    public IList<Person> Persons { get; set; }

    private const string STORAGE_FILE_NAME = "persons.json";

    public IPersonCache Cache { get; }
    
    public IEnumerable<Person> GetPersons()
    {
      return Persons; 
    }

    public void AddPerson(Person person)
    {
      Persons.Add(person);
      SavePersons(Persons);
    }

    private IEnumerable<Person> LoadPersons()
    {
      
      string json = File.ReadAllText(STORAGE_FILE_NAME);
      IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(json);
      return persons;
    }

    public void SavePersons(IEnumerable<Person> persons)
    {
      string json = JsonConvert.SerializeObject(persons);
      File.WriteAllText(STORAGE_FILE_NAME,json);
    }

  }
}
