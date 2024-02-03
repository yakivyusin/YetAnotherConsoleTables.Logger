namespace YetAnotherConsoleTables.Logger;

public static class LoggerExtensions
{
    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection) => logger.LogTable(logLevel, ConsoleTable.From(collection));

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection) => logger.LogTable(logLevel, eventId, ConsoleTable.From(collection));

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(logLevel, ConsoleTable.From(collection), tableFormat);

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(logLevel, eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTable(this ILogger logger, LogLevel logLevel, ConsoleTable table) => logger.LogTable(logLevel, 0, table, ConsoleTableFormat.Default);

    public static void LogTable(this ILogger logger, LogLevel logLevel, EventId eventId, ConsoleTable table) => logger.LogTable(logLevel, eventId, table, ConsoleTableFormat.Default);

    public static void LogTable(this ILogger logger, LogLevel logLevel, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(logLevel, 0, table, tableFormat);

    public static void LogTable(this ILogger logger, LogLevel logLevel, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat)
    {
        using var writer = new StringWriter();

        writer.WriteLine();
        table.Write(tableFormat, writer);
        
        logger.Log(logLevel, eventId, writer.ToString());
    }
}
