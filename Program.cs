using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using MyBlazorApp;
using MyBlazorApp.Services;
using System.Diagnostics;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configurazione componenti root
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurazione logging avanzato
builder.Logging.SetMinimumLevel(LogLevel.Debug);

#if DEBUG
// Configurazioni specifiche per ambiente di sviluppo
Console.WriteLine("🔧 MyBlazorApp avviata in modalità DEBUG");
Console.WriteLine($"📍 Environment: {builder.HostEnvironment.Environment}");
Console.WriteLine($"🌐 Base Address: {builder.HostEnvironment.BaseAddress}");
#endif

// Servizi dell'applicazione
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Servizio debug personalizzato
builder.Services.AddSingleton<IDebugService, DebugService>();

var host = builder.Build();

#if DEBUG
// Log informazioni di avvio
var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("🚀 MyBlazorApp started successfully");
logger.LogDebug("💻 Running on {Environment} environment", builder.HostEnvironment.Environment);

// Performance tracking
var stopwatch = Stopwatch.StartNew();
logger.LogDebug("⏱️ App startup time: {ElapsedMilliseconds}ms", stopwatch.ElapsedMilliseconds);
#endif

await host.RunAsync();
