# 🔧 Debug Features - MyBlazorApp

Questo documento descrive le funzionalità di debug avanzate implementate nel progetto MyBlazorApp.

## 📋 Funzionalità Implementate

### 1. 🛠️ Configurazione Debug Avanzata

- **File**: `Program.cs`
- **Descrizione**: Configurazione del logging e delle opzioni di sviluppo
- **Features**:
  - Logging a livello Debug abilitato
  - Messaggi di avvio informativi con emoji
  - Tracking del tempo di avvio
  - Environment detection

### 2. 🎯 Servizio Debug Personalizzato

- **Files**:
  - `Services/IDebugService.cs` (Interface)
  - `Services/DebugService.cs` (Implementation)
- **Descrizione**: Servizio centralizzato per gestione debug e diagnostica
- **Features**:
  - Raccolta e gestione log in tempo reale
  - Informazioni di sistema complete
  - Monitoraggio performance (memoria, uptime, contatori)
  - Event-driven log updates
  - Auto-limitazione log (max 100 entries)
  - Integrazione con browser console

### 3. 🖥️ Debug Console UI

- **File**: `Components/DebugConsole.razor`
- **Descrizione**: Componente UI per visualizzazione debug in tempo reale
- **Features**:
  - **Console retrattile** - Si apre/chiude con animazioni smooth
  - **Multi-tab interface**:
    - 📋 **Log Tab**: Visualizzazione log con filtri per livello
    - 🖥️ **System Tab**: Informazioni di sistema e ambiente
    - ⚡ **Performance Tab**: Metriche di performance in tempo reale
  - **Controlli avanzati**:
    - Clear logs
    - Auto-scroll toggle
    - Real-time updates
  - **Styling responsivo** con supporto mobile
  - **Color coding** per i diversi livelli di log

### 4. 🧪 Pagina Test Debug

- **File**: `Pages/DebugTest.razor`
- **Descrizione**: Interfaccia dedicata per testare le funzionalità debug
- **Features**:
  - **Generatore log interattivo** con tutti i livelli
  - **Generazione log casuali** per stress testing
  - **Simulazione errori** e scenari critici
  - **Test performance** asincroni
  - **Visualizzazione metriche** in tempo reale
  - **Dashboard statistiche** compatta

### 5. ⚙️ Configurazione VS Code

- **File**: `.vscode/launch.json`
- **Descrizione**: Configurazioni ottimizzate per debugging con VS Code
- **Features**:

  - **3 configurazioni diverse**:
    - 🌐 Debug Mode (Development environment)
    - 🔧 Attach Mode (per processi già avviati)
    - 🚀 Release Mode (Production testing)
  - **Compound configurations** per sessioni complete
  - **Environment variables** specifiche per modalità

- **File**: `.vscode/settings.json`
- **Descrizione**: Settings ottimizzati per sviluppo Blazor
- **Features**:
  - Configurazione Razor intellisense
  - Debug console personalizzata
  - File exclusions ottimizzate
  - PowerShell integration con welcome message

## 🚀 Come Utilizzare

### Debug Console

1. L'applicazione si avvia automaticamente con la debug console nascosta
2. Clicca sul pulsante 🔧 in basso a destra per aprire la console
3. Naviga tra i tab per vedere log, system info e performance
4. Usa i controlli per:
   - 🗑️ Pulire i log
   - ⬇️ Toggle auto-scroll
   - ❌ Nascondere la console

### Pagina Test Debug

1. Naviga su `/debug-test` (visibile solo in Debug mode)
2. Utilizza i controlli per:
   - Generare log di test con diversi livelli
   - Simulare errori e scenari
   - Monitorare le performance
   - Pulire i log

### VS Code Debug

1. Apri il progetto in VS Code
2. Vai su Debug panel (Ctrl+Shift+D)
3. Seleziona una delle configurazioni disponibili
4. Premi F5 per avviare il debug

## 📊 Monitoraggio Performance

Il sistema traccia automaticamente:

- **Memory Usage**: Utilizzo memoria .NET runtime
- **Log Count**: Numero totale di log generati
- **Uptime**: Tempo di attività dell'applicazione
- **System Info**: Environment, platform, base address

## 🎨 Personalizzazione

### Modificare i Livelli di Log

```csharp
// In Program.cs
builder.Logging.SetMinimumLevel(LogLevel.Information); // Cambia livello
```

### Aggiungere Categorie Custom

```csharp
// In qualsiasi componente
@inject IDebugService DebugService

DebugService.AddLog(LogLevel.Information, "Messaggio", "MiaCategoria");
```

### Modificare l'Auto-limit dei Log

```csharp
// In DebugService.cs - metodo AddLog
if (_logs.Count > 200) // Cambia da 100 a 200
{
    _logs.RemoveAt(0);
}
```

## 🔐 Sicurezza

- ✅ **Condizionale per Environment**: Debug features attive solo in Development
- ✅ **No Performance Impact**: Overhead minimo in Production
- ✅ **Memory Management**: Auto-cleanup dei log per evitare memory leak
- ✅ **Browser Integration**: Logging sicuro verso console browser

## 🐛 Troubleshooting

### La Debug Console non si apre?

- Verifica di essere in modalità Development
- Controlla la console browser per errori JavaScript
- Ricompila il progetto con `dotnet build`

### Log non vengono visualizzati?

- Verifica che il servizio sia registrato in `Program.cs`
- Controlla che il componente sia incluso nel layout
- Assicurati che il livello di log sia corretto

### Performance Issues?

- Riduci il limite dei log in `DebugService`
- Disabilita l'auto-refresh delle performance
- Usa filtri per categorie specifiche

## 🚀 Prossimi Sviluppi

- [ ] 📁 Export log to file
- [ ] 🔍 Log search e filtering avanzato
- [ ] 📊 Grafici performance real-time
- [ ] 🌐 Remote logging capability
- [ ] 🎨 Theme customization per debug console
- [ ] 📱 Mobile-optimized debug interface

---

**💡 Creato per migliorare l'esperienza di sviluppo con Blazor WebAssembly**
