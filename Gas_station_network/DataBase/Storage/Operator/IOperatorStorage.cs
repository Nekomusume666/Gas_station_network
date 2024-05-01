namespace Gas_station_network.DataBase.Storage.Operator;

/// <summary>
/// Интерфейс, предоставляющий функционал необходимый для оператора.
/// </summary>
interface IOperatorStorage
{
    /// <summary>
    /// Функция проверки топлива по названию.
    /// </summary>
    /// <param name="nameFuel">Название топлива.</param>
    /// <param name="adress">Адрес.</param>
    /// <returns>Результат проверки.</returns>
    public bool CheckFuelByName(string nameFuel, string adress);
}
