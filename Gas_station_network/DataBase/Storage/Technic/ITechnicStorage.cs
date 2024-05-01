using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Technic;

/// <summary>
/// Интерфейс, представляющий функционал техника.
/// </summary>
interface ITechnicStorage
{
    /// <summary>
    /// Выключение колонки.
    /// </summary>
    /// <param name="column">Колонка.</param>
    public void OffColumn(Column column);

    /// <summary>
    /// Включение колонки.
    /// </summary>
    /// <param name="column">Колонка.</param>
    public void OnColumn(Column column);
}
