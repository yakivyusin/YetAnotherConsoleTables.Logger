# YetAnotherConsoleTables.Logger [![NuGet](https://img.shields.io/nuget/v/YetAnotherConsoleTables.Logger.svg)](https://www.nuget.org/packages/YetAnotherConsoleTables.Logger/) [![Made in Ukraine](https://img.shields.io/badge/made_in-ukraine-ffd700.svg?labelColor=0057b7)](https://stand-with-ukraine.pp.ua)
The set of `Microsoft.Extensions.Logging.ILogger` extensions for logging object collections using the [YetAnotherConsoleTables](https://github.com/yakivyusin/YetAnotherConsoleTables) library. A tabular representation of a collection of objects can be useful in the case of logging to the console or a file.

```csharp
public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection);
public static void LogTable(this ILogger logger, LogLevel logLevel, ConsoleTable table);
public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection);
public static void LogTable(this ILogger logger, LogLevel logLevel, EventId eventId, ConsoleTable table);
public static void LogTable<T>(this ILogger logger, LogLevel logLevel, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTable(this ILogger logger, LogLevel logLevel, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTable<T>(this ILogger logger, LogLevel logLevel, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTable(this ILogger logger, LogLevel logLevel, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableTrace(this ILogger logger, ConsoleTable table);
public static void LogTableTrace<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableTrace(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableTrace(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableTrace<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableTrace(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableDebug(this ILogger logger, ConsoleTable table);
public static void LogTableDebug<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableDebug(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableDebug(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableDebug<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableDebug(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableInformation(this ILogger logger, ConsoleTable table);
public static void LogTableInformation<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableInformation(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableInformation(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableInformation<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableInformation(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableWarning(this ILogger logger, ConsoleTable table);
public static void LogTableWarning<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableWarning(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableWarning(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableWarning<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableWarning(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableError(this ILogger logger, ConsoleTable table);
public static void LogTableError<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableError(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableError(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableError<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableError(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);

public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection);
public static void LogTableCritical(this ILogger logger, ConsoleTable table);
public static void LogTableCritical<T>(this ILogger logger, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableCritical(this ILogger logger, ConsoleTable table, ConsoleTableFormat tableFormat);
public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection);
public static void LogTableCritical(this ILogger logger, EventId eventId, ConsoleTable table);
public static void LogTableCritical<T>(this ILogger logger, EventId eventId, IEnumerable<T> collection, ConsoleTableFormat tableFormat);
public static void LogTableCritical(this ILogger logger, EventId eventId, ConsoleTable table, ConsoleTableFormat tableFormat);
```