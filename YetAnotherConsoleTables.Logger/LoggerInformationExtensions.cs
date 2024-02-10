namespace YetAnotherConsoleTables.Logger;

public static class LoggerInformationExtensions
{
    public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTableInformation(ConsoleTable.From(collection));

    public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableInformation(ConsoleTable.From(collection), tableFormat);

    public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTableInformation(eventId, ConsoleTable.From(collection));

    public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTableInformation(eventId, ConsoleTable.From(collection), tableFormat);

    public static void LogTableInformation(this ILogger logger, ConsoleTable table) => logger.LogTable(LogLevel.Information, table);

    public static void LogTableInformation(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Information, table, tableFormat);

    public static void LogTableInformation(this ILogger logger, EventId eventId, ConsoleTable table) => logger.LogTable(LogLevel.Information, eventId, table);

    public static void LogTableInformation(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Information, eventId, table, tableFormat);
}
