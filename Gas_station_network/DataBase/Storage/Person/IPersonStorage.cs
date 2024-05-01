using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage;

/// <summary>
/// Интерфейс для взаимодействия с БД пользователей.
/// </summary>
interface IPersonStorage
{
    /// <summary>
    /// Добавить пользователя.
    /// </summary>
    /// <param name="person">Пользователь.</param>
    public void AddPerson(Person person);

    /// <summary>
    /// Проверка существования пользователя.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckPerson(string login, string password);

    /// <summary>
    /// Проверка существования пользователя.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckPerson(string login);

    /// <summary>
    /// Проверка логина на уникальность.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckUniqueLogin(string login);

    /// <summary>
    /// Получение роли по указанному логину.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <returns>Роль.</returns>
    public Role TakeRoleByLogin(string login);
}
