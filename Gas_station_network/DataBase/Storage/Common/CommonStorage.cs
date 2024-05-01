using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Common;

/// <summary>
/// Интерфейс с общим функционалом.
/// </summary>
internal class CommonStorage : ICommonStorage
{
    /// <summary>
    /// Проверка существования АЗС с таким адресом.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckGasStationByAdress(string adress)
    {
        using (var context = new GasStationDbContext())
        {
            return context.GasStations.Where(gs => gs.Address == adress) == null ? false : true;
        }
    }

    /// <summary>
    /// Получение адресов АЗС.
    /// </summary>
    /// <returns>Массив, содержащая адреса АЗС.</returns>
    public string[] TakeAdressGasStations()
    {
        using (var context = new GasStationDbContext())
        {
            return context.GasStations.Select(gs => gs.Address).ToArray();
        }
    }

    /// <summary>
    /// Получение колонок АЗС.
    /// </summary>
    /// <returns>Структура, содержащая информацию о колонках.</returns>
    public List<Column> TakeColumnGasStationByAdress(GasStation gasStation)
    {
        return gasStation.Columns;
    }

    public GasStation? TakeGasStationByAdress(string adress)
    {
        using (var context = new GasStationDbContext())
        {
            return context.GasStations.Where(gs => gs.Address == adress).FirstOrDefault();
        }
    }
}
