﻿namespace Gas_station_network.DataBase.Storage.Technic;

/// <summary>
/// Интерфейс, предоставляющий функционал необходимый для техика.
/// </summary>
interface ITechnicStorage
{
    /// <summary>
    /// Выключение колонки по номеру.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <param name="numberColumn">Номер колонки.</param>
    /// <returns>Результат выполнения операции.</returns>
    public bool OffColumn(string adress, int numberColumn);

    /// <summary>
    /// Включение колонки по номеру.
    /// </summary>
    /// <param name="adress">Адрес.</param>
    /// <param name="numberColumn">Номер колонки.</param>
    /// <returns>Результат выполнения операции.</returns>
    public bool OnColumn(string adress, int numberColumn);
}