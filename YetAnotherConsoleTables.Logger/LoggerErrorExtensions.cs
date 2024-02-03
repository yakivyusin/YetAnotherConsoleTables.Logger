namespace YetAnotherConsoleTables.Logger;

public static class LoggerErrorExtensions
{
    public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableError(ConsoleTable.From(collection));

    public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableError(ConsoleTable.From(collection), tableFormat);

    public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableError(eventId, ConsoleTable.From(collection));

    public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableError(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableError(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Error, table);

    public static void LogTableError(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Error, table, tableFormat);

    public static void LogTableError(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Error, eventId, table);

    public static void LogTableError(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Error, eventId, table, tableFormat);
}
