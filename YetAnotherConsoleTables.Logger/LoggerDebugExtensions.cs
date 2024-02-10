namespace YetAnotherConsoleTables.Logger;

public static class LoggerDebugExtensions
{
    public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableDebug(ConsoleTable.From(collection));

    public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableDebug(ConsoleTable.From(collection), tableFormat);

    public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableDebug(eventId, ConsoleTable.From(collection));

    public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableDebug(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableDebug(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Debug, table);

    public static void LogTableDebug(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Debug, table, tableFormat);

    public static void LogTableDebug(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Debug, eventId, table);

    public static void LogTableDebug(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Debug, eventId, table, tableFormat);
}
