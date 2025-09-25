using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System.Collections.Concurrent;

namespace MyBlazorApp.Services;

/// <summary>
/// Implementazione del servizio di debug per MyBlazorApp
/// </summary>
public class DebugService : IDebugService
{
    private readonly List<DebugLogEntry> _logs = new();
    private readonly IWebAssemblyHostEnvironment _hostEnvironment;
    private readonly IJSRuntime _jsRuntime;
    private readonly DateTime _startTime;

    public IReadOnlyList<DebugLogEntry> DebugLogs => _logs.AsReadOnly();

    public SystemInfo SystemInfo { get; }

    public event Action? OnLogAdded;

    public DebugService(IWebAssemblyHostEnvironment hostEnvironment, IJSRuntime jsRuntime)
    {
        _hostEnvironment = hostEnvironment;
        _jsRuntime = jsRuntime;
        _startTime = DateTime.Now;

        SystemInfo = new SystemInfo(
            UserAgent: "Browser", // Sarà aggiornato via JS
            Platform: Environment.OSVersion.Platform.ToString(),
            Environment: _hostEnvironment.Environment,
            BaseAddress: _hostEnvironment.BaseAddress,
            StartTime: _startTime
        );

        // Log di inizializzazione
        AddLog(LogLevel.Information, "🔧 DebugService inizializzato", "System");

        // Inizializza informazioni del browser
        _ = InitializeBrowserInfoAsync();
    }

    public void AddLog(LogLevel level, string message, string? category = null)
    {
        var logEntry = new DebugLogEntry(
            DateTime.Now,
            level,
            message,
            category
        );

        _logs.Add(logEntry);

        // Mantieni solo gli ultimi 100 log per evitare memory leak
        if (_logs.Count > 100)
        {
            _logs.RemoveAt(0);
        }

        OnLogAdded?.Invoke();

        // Log anche nella console del browser
        _ = LogToBrowserConsoleAsync(level, message, category);
    }

    public void ClearLogs()
    {
        _logs.Clear();
        AddLog(LogLevel.Information, "🧹 Log puliti", "Debug");
    }

    public PerformanceInfo GetPerformanceInfo()
    {
        var uptime = DateTime.Now - _startTime;
        var memoryUsage = GC.GetTotalMemory(false);

        return new PerformanceInfo(
            Uptime: uptime,
            LogCount: _logs.Count,
            MemoryUsage: memoryUsage
        );
    }

    private async Task InitializeBrowserInfoAsync()
    {
        try
        {
            var userAgent = await _jsRuntime.InvokeAsync<string>("eval", "navigator.userAgent");
            var platform = await _jsRuntime.InvokeAsync<string>("eval", "navigator.platform");

            AddLog(LogLevel.Debug, $"🌐 User Agent: {userAgent}", "Browser");
            AddLog(LogLevel.Debug, $"💻 Platform: {platform}", "Browser");
        }
        catch (Exception ex)
        {
            AddLog(LogLevel.Error, $"❌ Errore durante l'inizializzazione info browser: {ex.Message}", "Browser");
        }
    }

    private async Task LogToBrowserConsoleAsync(LogLevel level, string message, string? category)
    {
        try
        {
            var prefix = category != null ? $"[{category}]" : "[MyBlazorApp]";
            var fullMessage = $"{prefix} {message}";

            var consoleMethod = level switch
            {
                LogLevel.Error or LogLevel.Critical => "error",
                LogLevel.Warning => "warn",
                LogLevel.Information => "info",
                LogLevel.Debug => "debug",
                _ => "log"
            };

            await _jsRuntime.InvokeVoidAsync("console." + consoleMethod, fullMessage);
        }
        catch
        {
            // Ignora errori nel logging su console - potrebbe non essere disponibile
        }
    }
}