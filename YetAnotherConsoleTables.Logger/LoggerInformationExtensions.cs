using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace YetAnotherConsoleTables.Logger;

public static class LoggerInformationExtensions
{
    public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection) => logger.LogTable(LogLevel.Information, 0, collection, ConsoleTableFormat.Default);

    public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Information, 0, collection, tableFormat);

    public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection) => logger.LogTable(LogLevel.Information, eventId, collection, ConsoleTableFormat.Default);

    public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat) => logger.LogTable(LogLevel.Information, eventId, collection, tableFormat);
}
