using Gas_station_network.DataBase;

namespace Gas_station_network.Model;

/// <summary>
/// Класс, представляющий пользователей.
/// </summary>
public class Person
{
    /// <summary>
    /// Логин.
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Роль.
    /// </summary>
    public Role UserRole { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <param name="userRole">Роль.</param>
    public Person(string login, string password, Role userRole)
    {
        Login = login;
        Password = password;
        UserRole = userRole;
    }
}