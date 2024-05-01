using Gas_station_network.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_station_network.DataBase.Storage;

/// <summary>
/// Объект для взаимодействия с БД пользователей.
/// </summary>
class PersonStorage : IPersonStorage
{
    /// <summary>
    /// Добавить пользователя.
    /// </summary>
    /// <param name="person">Пользователь.</param>
    public void AddPerson(Person person)
    {
        using (var context = new PersonDbContext())
        {
            var entity = context.Add(person);
            entity.State = EntityState.Added;

            context.SaveChanges();
        }
    }

    /// <summary>
    /// Проверка существования пользователя.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckPerson(string login, string password)
    {
        using (var context = new PersonDbContext())
        {
            return context.Persons.Any(p => p.Login == login && p.Password == password);
        }
    }

    /// <summary>
    /// Проверка логина на уникальность.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckUniqueLogin(string login)
    {
        using (var context = new PersonDbContext())
        {
            return !context.Persons.Any(p => p.Login == login);
        }
    }
}
