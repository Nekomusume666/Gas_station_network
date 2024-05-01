using System.ComponentModel.DataAnnotations;

namespace Gas_station_network.Model;

/// <summary>
/// Класс, характеризующий колонку.
/// </summary>
class Column
{
    [Key]
    public int ID { get; set; }

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
    /// Цена топлива.
    /// </summary>
    public double PriceFuel { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="number">Номер.</param>
    /// <param name="isActive">Рабочее состояние.</param>
    /// <param name="nameFuel">Название топлива.</param>
    /// <param name="volumeFuel">Количество топлива.</param>
    /// <param name="priceFuel">Цена топлива.</param>
    public Column(int number, bool isActive, string nameFuel, int volumeFuel, double priceFuel)
    {
        Number = number;
        IsActive = isActive;
        NameFuel = nameFuel;
        VolumeFuel = volumeFuel;
    }
}
