namespace YetAnotherConsoleTables.Logger;

public static class LoggerTraceExtensions
{
    public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableTrace(ConsoleTable.From(collection));

    public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableTrace(ConsoleTable.From(collection), tableFormat);

    public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableTrace(eventId, ConsoleTable.From(collection));

    public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableTrace(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableTrace(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Trace, table);

    public static void LogTableTrace(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Trace, table, tableFormat);

    public static void LogTableTrace(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Trace, eventId, table);

    public static void LogTableTrace(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Trace, eventId, table, tableFormat);
}
