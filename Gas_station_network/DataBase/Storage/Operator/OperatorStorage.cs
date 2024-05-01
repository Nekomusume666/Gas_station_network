using Gas_station_network.DataBase.Storage.Common;
using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Operator;

/// <summary>
/// Класс, предоставляющий функционал необходимый для оператора.
/// </summary>
internal class OperatorStorage : IOperatorStorage
{
    /// <summary>
    /// Функция проверки топлива по названию.
    /// </summary>
    /// <param name="nameFuel">Название топлива.</param>
    /// <param name="adress">Адрес.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckFuelByName(string nameFuel, string adress)
    {
        var gasStation = TakeInfoGasStationByAdress(adress);

        if (gasStation == null)
        {
            return false;
        }

        var column = gasStation.Columns.Where(c => c.NameFuel == nameFuel).First();

        if (column == null)
        {
            return false;
        }

        return column.IsActive;
    }

    private GasStation? TakeInfoGasStationByAdress(string adress)
    {
        using (var context = new GasStationDbContext())
        {
            var gasStation = context.GasStations.Where(gs => gs.Address == adress).FirstOrDefault();

            return gasStation;
        }
    }
}
