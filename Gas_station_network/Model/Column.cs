namespace Gas_station_network.Model;

/// <summary>
/// Класс, характеризующий колонку.
/// </summary>
class Column
{
    /// <summary>
    /// Номер колонки.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Флаг рабочего состояния колонки.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Название топлива.
    /// </summary>
    public string NameFuel { get; set; }

    /// <summary>
    /// Количество топлива.
    /// </summary>
    public int VolumeFuel { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="number">Номер.</param>
    /// <param name="isActive">Рабочее состояние.</param>
    /// <param name="nameFuel">Название топлива.</param>
    /// <param name="volume">Количество топлива.</param>
    public Column(int number, bool isActive, string nameFuel, int volume)
    {
        Number = number;
        IsActive = isActive;
        NameFuel = nameFuel;
        VolumeFuel = volume;
    }
}
