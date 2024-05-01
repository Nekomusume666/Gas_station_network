using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Admin;

/// <summary>
/// Интерфейс, представляющий функционал администратора.
/// </summary>
interface IAdminStorage 
{
    /// <summary>
    /// Добавить сотрудника.
    /// </summary>
    /// <param name="person">Сотрудник.</param>
    public void AddPerson(Person person);

    /// <summary>
    /// Удалить сотрудника по логину.
    /// </summary>
    /// <param name="login">Логин.</param>
    public void RemovePersonByLogin(string login);

    /// <summary>
    /// Поменять цену топлива.
    /// </summary>
    /// <param name="priceFuel">Значения в виде: название топлива - новая цена.</param>
    /// <param name="adress">Адрес станции.</param>
    public void ChangePriceFuel(Dictionary<string, double> priceFuel, string adress);
}
