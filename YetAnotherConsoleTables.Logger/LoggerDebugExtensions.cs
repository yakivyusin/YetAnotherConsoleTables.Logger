using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace YetAnotherConsoleTables.Logger;

public static class LoggerDebugExtensions
{
    public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Debug, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Debug, 0, collection, tableFormat);

    public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Debug, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Debug, eventId, collection, tableFormat);
}
