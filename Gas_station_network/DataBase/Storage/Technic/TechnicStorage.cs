using Gas_station_network.Core;
using Gas_station_network.Model;

namespace Gas_station_network.DataBase.Storage.Technic;

/// <summary>
/// Класс, представляющий функционал техника.
/// </summary>
internal class TechnicStorage : ITechnicStorage
{
    public void OffColumn(Column column)
    {
        using (var context = new GasStationDbContext())
        {
            column.IsActive = false;
            context.SaveChanges();
        }
    }

    public void OnColumn(Column column)
    {
        using (var context = new GasStationDbContext())
        {
            column.IsActive = true;
            context.SaveChanges();
        }
    }
}
