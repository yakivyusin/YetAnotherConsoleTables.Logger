namespace YetAnotherConsoleTables.Logger;

public static class LoggerWarningExtensions
{
    public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableWarning(ConsoleTable.From(collection));

    public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableWarning(ConsoleTable.From(collection), tableFormat);

    public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableWarning(eventId, ConsoleTable.From(collection));

    public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableWarning(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableWarning(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Warning, table);

    public static void LogTableWarning(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Warning, table, tableFormat);

    public static void LogTableWarning(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Warning, eventId, table);

    public static void LogTableWarning(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Warning, eventId, table, tableFormat);
}
