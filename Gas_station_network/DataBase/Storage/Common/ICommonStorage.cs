using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Common;

/// <summary>
/// Интерфейс с общим функционалом.
/// </summary>
interface ICommonStorage
{
    /// <summary>
    /// Получение адресов АЗС.
    /// </summary>
    /// <returns>Массив, содержащая адреса АЗС.</returns>
    public string[] TakeAdressGasStations();

    /// <summary>
    /// Получение колонок АЗС по адресу.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <returns>Структура, содержащая информацию о колонках.</returns>
    public List<Column> TakeColumnGasStationByAdress(string adress);

    /// <summary>
    /// Проверка существования АЗС с таким адресом.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckGasStationByAdress(string adress);
}
