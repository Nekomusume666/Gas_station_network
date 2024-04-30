namespace Gas_station_network.Model;

/// <summary>
/// Класс, характеризующий АЗС.
/// </summary>
class GasStation
{
    /// <summary>
    /// Адрес.
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Колонки.
    /// </summary>
    public List<Column> Columns { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="address">Адрес.</param>
    public GasStation(string address)
    {
        Address = address;
        Columns = new List<Column>();

        // заглушка (пока так :) )
        AddColumn(1, true, "A95", 100);
        AddColumn(1, true, "A98", 100);
        AddColumn(1, true, "A100", 100);
    }

    public void AddColumn(int number, bool isActive, string name, int volume)
    {
        Column column = new Column(number, isActive, name, volume);

        Columns.Add(column);
    }
}
