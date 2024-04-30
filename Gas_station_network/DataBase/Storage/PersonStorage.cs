using Gas_station_network.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_station_network.DataBase.Storage;

class PersonStorage : IPersonStorage
{
    public void AddPerson(Person person)
    {
        using (var context = new PersonDbContext())
        {
            var entity = context.Add(person);
            entity.State = EntityState.Added;

            context.SaveChanges();
        }
    }
}
