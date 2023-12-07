using DemoLib.Models;

namespace DemoLib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}