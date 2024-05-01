using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Gas_station_network.DataBase.Storage.Technic;

/// <summary>
/// Класс, предоставляющий функционал необходимый для оператора.
/// </summary>
internal class TechnicStorage : ITechnicStorage
{
    /// <summary>
    /// Выключение колонки по номеру.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <param name="numberColumn">Номер колонки.</param>
    /// <returns>Результат выполнения операции.</returns>
    public bool OffColumn(string adress, int numberColumn)
    {
        using (var context = new GasStationDbContext())
        {
            var gasStation = context.GasStations.Where(gs => gs.Address == adress).FirstOrDefault();

            if (gasStation == null)
            {
                return false;
            }

            var column = gasStation.Columns.Where(c => c.Number == numberColumn).FirstOrDefault();

            if (column == null)
            {
                return false;
            }

            column.IsActive = false;
            context.SaveChanges();

            return true;
        }
    }

    /// <summary>
    /// Включение колонки по номеру.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <param name="numberColumn">Номер колонки.</param>
    /// <returns>Результат выполнения операции.</returns>
    public bool OnColumn(string adress, int numberColumn)
    {
        using (var context = new GasStationDbContext())
        {
            var gasStation = context.GasStations.Where(gs => gs.Address == adress).FirstOrDefault();

            if (gasStation == null)
            {
                return false;
            }

            var column = gasStation.Columns.Where(c => c.Number == numberColumn).FirstOrDefault();

            if (column == null)
            {
                return false;
            }

            column.IsActive = true;
            context.SaveChanges();

            return true;
        }
    }

    // Плохая реализация - оставляю до разбирательства по функционалу.
}
