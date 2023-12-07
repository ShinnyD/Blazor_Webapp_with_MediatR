using System;
using DemoLib.Models;

namespace DemoLib.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly List<PersonModel> people = new();
        public DataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Max", LastName = "Mustermann" });
            people.Add(new PersonModel { Id = 2, FirstName = "Maxine", LastName = "Musterfrau" });
            people.Add(new PersonModel { Id = 2, FirstName = "Aaron", LastName = "Visang" });
            people.Add(new PersonModel { Id = 2, FirstName = "Christian", LastName = "Surges" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}

