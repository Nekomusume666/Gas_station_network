using Gas_station_network.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_station_network.DataBase.Storage;

/// <summary>
/// Объект для взаимодействия с БД пользователей.
/// </summary>
class PersonStorage : IPersonStorage
{
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
    /// Проверка существования пользователя.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckPerson(string login)
    {
        using (var context = new PersonDbContext())
        {
            return context.Persons.Any(p => p.Login == login);
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

    /// <summary>
    /// Получение роли по указанному логину.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Роль.</returns>
    public Role TakeRoleByLogin(string login)
    {
        using (var context = new PersonDbContext())
        {
            var person = context.Persons.FirstOrDefault(p => p.Login == login);

            return person == null ? Role.None : person.UserRole;
        }
    }
}
