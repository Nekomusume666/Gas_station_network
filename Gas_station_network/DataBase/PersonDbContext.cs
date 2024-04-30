using Gas_station_network.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_station_network.DataBase;

/// <summary>
/// Класс, для взаимодействия с таблицой пользователей.
/// </summary>
class PersonDbContext : DbContext
{
    /// <summary>
    /// Таблица пользователей.
    /// </summary>
    public DbSet<Person> Persons { get; set; }

    /// <summary>
    /// Создаем БД.
    /// </summary>
    public PersonDbContext()
    {
        Database.EnsureCreated();
    }

    /// <summary>
    /// Место хранения БД.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=Persons.db");
    }
}
