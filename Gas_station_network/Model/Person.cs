using Gas_station_network.DataBase;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Gas_station_network.Model;

/// <summary>
/// Класс, представляющий пользователей.
/// </summary>
public class Person
{
    /// <summary>
    /// Логин.
    /// </summary>
    [Key]
    public string Login { get; set; }

    /// <summary>
    /// Пароль.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Телефон.
    /// </summary>
    public string Phone { get; set; }

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
    /// <param name="firstName">Имя.</param>
    /// <param name="lastName">Фамилия.</param>
    /// <param name="phone">Телефон.</param>
    public Person(string login, string password, Role userRole, string firstName, string lastName, string phone)
    {
        Login = login;
        Password = password;
        UserRole = userRole;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }
}