using Gas_station_network.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_station_network.DataBase;

class GasStationDbContext : DbContext
{
    /// <summary>
    /// Таблица АЗС.
    /// </summary>
    public DbSet<GasStation> GasStations { get; set; }

    /// <summary>
    /// Создаем БД.
    /// </summary>
    public GasStationDbContext()
    {
        Database.EnsureCreated();
    }

    /// <summary>
    /// Место хранения БД.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=GasStations.db");
    }
}
