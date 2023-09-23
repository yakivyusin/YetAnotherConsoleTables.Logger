namespace YetAnotherConsoleTables.Logger;

public static class LoggerWarningExtensions
{
    public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Warning, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Warning, 0, collection, tableFormat);

    public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Warning, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Warning, eventId, collection, tableFormat);
}
