using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;

namespace YetAnotherConsoleTables.Logger;

public static class LoggerExtensions
{
    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection) => logger.LogTable(logLevel, 0, collection, ConsoleTableFormat.Default);

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection) => logger.LogTable(logLevel, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(logLevel, 0, collection, tableFormat);

    public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat)
    {
        using var writer = new StringWriter();

        writer.WriteLine();
        ConsoleTable.From(collection).Write(tableFormat, writer);
        
        logger.Log(logLevel, eventId, writer.ToString());
    }
}
