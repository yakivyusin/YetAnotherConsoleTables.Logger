namespace YetAnotherConsoleTables.Logger;

public static class LoggerErrorExtensions
{
    public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Error, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Error, 0, collection, tableFormat);

    public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Error, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Error, eventId, collection, tableFormat);
}
