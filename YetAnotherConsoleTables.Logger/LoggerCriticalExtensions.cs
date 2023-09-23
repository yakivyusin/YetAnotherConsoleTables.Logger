namespace YetAnotherConsoleTables.Logger;

public static class LoggerCriticalExtensions
{
    public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Critical, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Critical, 0, collection, tableFormat);

    public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Critical, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Critical, eventId, collection, tableFormat);
}
