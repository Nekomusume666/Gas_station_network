using Gas_station_network.Core;
using Gas_station_network.Model;
using System;

namespace Gas_station_network.DataBase.Storage.Admin;

/// <summary>
/// Класс, представляющий функционал администратора.
/// </summary>
internal class AdminStorage : IAdminStorage
{
    /// <summary>
    /// Добавить сотрудника.
    /// </summary>
    /// <param name="person">Сотрудник.</param>
    public void AddPerson(Person person)
    {
        using (var context = new PersonDbContext())
        {
            var entity = context.Add(person);

            context.SaveChanges();
        }
    }

    /// <summary>
    /// Удалить сотрудника по логину.
    /// </summary>
    /// <param name="login">Логин.</param>
    public void RemovePersonByLogin(string login)
    {
        using (var context = new PersonDbContext())
        {
            var entity = context.Remove(context.Persons.First(x => x.Login == login));

            context.SaveChanges();
        }
    }

    /// <summary>
    /// Поменять цену топлива.
    /// </summary>
    /// <param name="priceFuel">Название топлива - новая цена.</param>
    /// <param name="adress">Адрес станции.</param>
    public void ChangePriceFuel(Dictionary<string, double> priceFuel, string adress)
    {
        using (var context = new GasStationDbContext())
        {
            var entity = context.GasStations.FirstOrDefault(gs => gs.Address == adress);

            UpdateFuelPrices(priceFuel, entity!.Columns);

            context.SaveChanges();
        }
    }

    private void UpdateFuelPrices(Dictionary<string, double> newPrices, List<Column> columns)
    {
        foreach (var column in columns)
        {
            foreach (var fuel in newPrices)
            {
                if (column.NameFuel == fuel.Key)
                {
                    column.PriceFuel = fuel.Value;
                }
            }
        }
    }
}
