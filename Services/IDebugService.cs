using Microsoft.Extensions.Logging;

namespace MyBlazorApp.Services;

/// <summary>
/// Interfaccia per il servizio di debug e diagnostica dell'applicazione
/// </summary>
public interface IDebugService
{
    /// <summary>
    /// Lista dei log di debug
    /// </summary>
    IReadOnlyList<DebugLogEntry> DebugLogs { get; }
    
    /// <summary>
    /// Informazioni di sistema
    /// </summary>
    SystemInfo SystemInfo { get; }
    
    /// <summary>
    /// Evento scatenato quando viene aggiunto un nuovo log
    /// </summary>
    event Action? OnLogAdded;
    
    /// <summary>
    /// Aggiunge un log di debug
    /// </summary>
    /// <param name="level">Livello del log</param>
    /// <param name="message">Messaggio</param>
    /// <param name="category">Categoria opzionale</param>
    void AddLog(LogLevel level, string message, string? category = null);
    
    /// <summary>
    /// Pulisce tutti i log
    /// </summary>
    void ClearLogs();
    
    /// <summary>
    /// Ottiene le performance dell'applicazione
    /// </summary>
    PerformanceInfo GetPerformanceInfo();
}

/// <summary>
/// Entry del log di debug
/// </summary>
public record DebugLogEntry(
    DateTime Timestamp,
    LogLevel Level,
    string Message,
    string? Category = null
);

/// <summary>
/// Informazioni di sistema
/// </summary>
public record SystemInfo(
    string UserAgent,
    string Platform,
    string Environment,
    string BaseAddress,
    DateTime StartTime
);

/// <summary>
/// Informazioni sulle performance
/// </summary>
public record PerformanceInfo(
    TimeSpan Uptime,
    int LogCount,
    long MemoryUsage
);