using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace YetAnotherConsoleTables.Logger;

public static class LoggerTraceExtensions
{
    public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Trace, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Trace, 0, collection, tableFormat);

    public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Trace, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Trace, eventId, collection, tableFormat);
}
