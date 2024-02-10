namespace YetAnotherConsoleTables.Logger;

public static class LoggerCriticalExtensions
{
    public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableCritical(ConsoleTable.From(collection));

    public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableCritical(ConsoleTable.From(collection), tableFormat);

    public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableCritical(eventId, ConsoleTable.From(collection));

    public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableCritical(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableCritical(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Critical, table);

    public static void LogTableCritical(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Critical, table, tableFormat);

    public static void LogTableCritical(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Critical, eventId, table);

    public static void LogTableCritical(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Critical, eventId, table, tableFormat);
}
