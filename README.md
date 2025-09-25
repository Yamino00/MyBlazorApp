# 💰 MyBlazorApp - Gestione Budget Personale

<div align="center">

![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

**🌐 [Demo Live](https://yamino00.github.io/MyBlazorApp/) | 👨‍💻 Sviluppato da Federico Vincenzo Leccese**

_Un'applicazione moderna per la gestione del budget personale costruita con Blazor WebAssembly_

</div>

---

## 📋 Indice

- [🎯 Descrizione del progetto](#-descrizione-del-progetto)
- [🛠️ Realizzazione tecnica](#️-realizzazione-tecnica)
- [🏗️ Architettura e funzionalità](#️-architettura-e-funzionalità)
- [⚡ Vantaggi dell'approccio Blazor WebAssembly](#-vantaggi-dellapproccio-blazor-webassembly)
- [🚀 Tecnologie utilizzate](#-tecnologie-utilizzate)
- [📸 Screenshots](#-screenshots)
- [🛠️ Installazione e utilizzo](#️-installazione-e-utilizzo)
- [📁 Struttura del progetto](#-struttura-del-progetto)
- [🔮 Sviluppi futuri](#-sviluppi-futuri)
- [📄 Licenza](#-licenza)

---

## 🎯 Descrizione del progetto

MyBlazorApp è un'**applicazione web per la gestione del budget personale** che ha l'obiettivo di mostrare in maniera pratica le potenzialità del framework **Blazor WebAssembly** per lo sviluppo di Single Page Application (SPA) moderne e responsive.

L'applicazione, strutturata come un sistema completo di tracciamento finanziario, rappresenta un **esempio concreto** di come sia possibile creare interfacce utente interattive e funzionali utilizzando esclusivamente **C# e .NET**, senza dover ricorrere a JavaScript per la logica di business.

### ✨ Caratteristiche principali

- 📊 **Dashboard completa** con panoramica finanziaria
- 💳 **Gestione spese** con categorizzazione automatica
- 📈 **Sistema di reporting** avanzato con grafici
- 📱 **Design responsive** per tutti i dispositivi
- 🎨 **Interfaccia moderna** con Bootstrap 5

---

## 🛠️ Realizzazione tecnica

L'applicazione è stata sviluppata utilizzando **Blazor WebAssembly**, che consente di eseguire codice .NET direttamente nel browser del client, offrendo prestazioni elevate e un'esperienza utente fluida.

La struttura del progetto è stata progettata seguendo le **best practices di Blazor** e include i seguenti componenti principali:

### 🏠 1. Dashboard principale

Fornisce una panoramica completa delle finanze personali con:

- 💰 Cards riepilogative per entrate, spese e bilancio corrente
- 🎯 Visualizzazione obiettivi di risparmio
- 📋 Lista delle transazioni più recenti
- 📊 Grafici distribuzione spese per categoria

### 💳 2. Gestione spese

Sistema completo per il tracking delle spese con:

- ✍️ Form di inserimento validato
- 🏷️ Categorizzazione automatica delle transazioni
- 📱 Interfaccia responsive per input rapido
- 📈 Calcolo automatico dei totali

### 📊 3. Sistema di reporting

Analytics avanzata delle finanze con:

- 🔍 Filtri per periodo (mese/trimestre/anno)
- 🏷️ Filtri per categoria di spesa
- 📈 Grafici interattivi per la visualizzazione dati
- 🎯 Tracking degli obiettivi di risparmio con progress bar

### 📱 4. Layout responsive

Design moderno e funzionale con:

- 🎨 Bootstrap 5 per garantire compatibilità cross-device
- 🧭 Navigazione intuitiva con menu collapsible
- 💫 Animazioni e transizioni fluide
- 🎨 Palette colori tematica per le finanze

---

## 🏗️ Architettura e funzionalità

Il progetto implementa un'**architettura component-based** che garantisce:

| Caratteristica                          | Descrizione                                                                    |
| --------------------------------------- | ------------------------------------------------------------------------------ |
| 🔧 **Separazione delle responsabilità** | Componenti specializzati per layout, navigazione e funzionalità specifiche     |
| 🔄 **Gestione dello stato locale**      | Binding bidirezionale e reactive programming per interfaccia sempre aggiornata |
| ✅ **Validazione integrata**            | Controlli automatici sui form di input e feedback immediato all'utente         |
| 🎭 **Simulazione dati realistica**      | Transazioni di esempio e calcoli automatici per demo delle potenzialità        |

---

## ⚡ Vantaggi dell'approccio Blazor WebAssembly

Grazie alla tecnologia **Blazor WebAssembly**, questa applicazione dimostra diversi vantaggi significativi:

### 🎯 Sviluppo Unificato

- 🔄 Utilizzo di **C#** sia per logica client che per future estensioni server-side
- 📚 Condivisione di modelli e logica tra client e server
- 🛠️ Tooling unificato per debugging e development

### 🚀 Performance Ottimizzate

- ⚡ Esecuzione di codice **.NET compilato** direttamente nel browser
- 🎮 Utilizzo della potenza di **WebAssembly** per calcoli complessi
- 📱 Esperienza utente fluida senza round-trip al server

### 🔗 Ecosistema .NET Completo

- 📦 Accesso a tutte le librerie **.NET** esistenti
- 🛠️ Strumenti di debugging familiari agli sviluppatori .NET
- 📋 Pattern e architetture consolidate del mondo .NET

### 🌐 Deployment Semplificato

- 📄 Hosting su qualsiasi **server web statico**
- 🚫 Nessuna necessità di runtime server-side
- 🔧 Deploy automatico su **GitHub Pages**

---

## 🚀 Tecnologie utilizzate

<div align="center">

| Tecnologia                                                                                                               | Versione        | Utilizzo                          |
| ------------------------------------------------------------------------------------------------------------------------ | --------------- | --------------------------------- |
| ![.NET](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white)                            | **9.0**         | Framework di base                 |
| ![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=flat-square&logo=blazor&logoColor=white)                      | **WebAssembly** | Interfaccia utente interattiva    |
| ![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=flat-square&logo=bootstrap&logoColor=white)             | **5.x**         | Design responsive e componenti UI |
| ![Bootstrap Icons](https://img.shields.io/badge/Bootstrap_Icons-7952B3?style=flat-square&logo=bootstrap&logoColor=white) | **Latest**      | Iconografia moderna               |
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)                           | **12**          | Linguaggio di programmazione      |
| ![Razor](https://img.shields.io/badge/Razor-512BD4?style=flat-square&logo=razor&logoColor=white)                         | **Components**  | Composizione interfaccia utente   |

</div>

---

## 📸 Screenshots

> **Nota**: Le screenshots mostrano l'interfaccia dell'applicazione nelle sue diverse sezioni.

### 🏠 Dashboard

La dashboard principale mostra una panoramica completa delle finanze personali con cards informative e grafici.

### 💳 Gestione Spese

Interfaccia intuitiva per l'inserimento e la gestione delle spese quotidiane.

### 📊 Reports

Sistema di reporting avanzato con filtri e visualizzazioni grafiche dei dati finanziari.

---

## 🛠️ Installazione e utilizzo

### Prerequisiti

- ![.NET](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white) **.NET 9.0 SDK** o superiore
- 🌐 Browser moderno con supporto **WebAssembly**

### 🚀 Avvio locale

```bash
# Clona il repository
git clone https://github.com/Yamino00/MyBlazorApp.git

# Naviga nella directory del progetto
cd MyBlazorApp

# Esegui l'applicazione
dotnet run
```

L'applicazione sarà disponibile su `https://localhost:7274` (HTTPS) o `http://localhost:5097` (HTTP).

### 🌐 Demo online

Puoi testare l'applicazione direttamente online: **[MyBlazorApp Demo](https://yamino00.github.io/MyBlazorApp/)**

---

## 📁 Struttura del progetto

```
MyBlazorApp/
├── 📁 Layout/                 # Componenti di layout
│   ├── MainLayout.razor       # Layout principale
│   ├── MainLayout.razor.css   # Stili layout
│   ├── NavMenu.razor          # Menu di navigazione
│   └── NavMenu.razor.css      # Stili menu
├── 📁 Pages/                  # Pagine dell'applicazione
│   ├── Home.razor             # Dashboard principale
│   ├── Counter.razor          # Gestione spese
│   └── Weather.razor          # Reports finanziari
├── 📁 wwwroot/                # Asset statici
│   ├── css/                   # Fogli di stile
│   ├── lib/                   # Librerie (Bootstrap)
│   └── index.html             # Pagina principale
├── App.razor                  # Componente root
├── Program.cs                 # Entry point applicazione
└── _Imports.razor             # Import globali
```

---

## 🔮 Sviluppi futuri

Possibili miglioramenti e funzionalità da implementare:

- [ ] 💾 **Persistenza dati** con Local Storage o API backend
- [ ] 🔐 **Sistema di autenticazione** utenti
- [ ] 📊 **Grafici avanzati** con Chart.js o similar
- [ ] 📧 **Notifiche** per obiettivi di risparmio
- [ ] 📱 **Progressive Web App** (PWA) support
- [ ] 🌐 **Internazionalizzazione** multi-lingua
- [ ] 📤 **Export dati** in CSV/PDF
- [ ] 🔄 **Sincronizzazione** con servizi bancari
- [ ] 📋 **Budget planning** avanzato
- [ ] 🎨 **Temi personalizzabili**

## 🔧 Debug Features _(NEW!)_

Il progetto include ora un **sistema di debug avanzato** per migliorare l'esperienza di sviluppo:

### ✨ Funzionalità Debug Implementate

- 🖥️ **Debug Console** retrattile con interface multi-tab
- 📊 **Monitoraggio performance** in tempo reale
- 🔍 **Sistema di logging** centralizzato con categorizzazione
- 🧪 **Pagina test debug** per simulazioni e stress testing
- ⚙️ **Configurazioni VS Code** ottimizzate per Blazor debugging

### 🚀 Come Accedere

1. **Debug Console**: Clicca il pulsante 🔧 in basso a destra (solo in Development)
2. **Test Page**: Naviga su `/debug-test` dal menu (solo in Development)
3. **VS Code Debug**: Usa le configurazioni in `.vscode/launch.json`

📖 **Documentazione completa**: Vedi [`DEBUG_FEATURES.md`](./DEBUG_FEATURES.md) per dettagli tecnici

---

<div align="center">

**💡 Progetto realizzato per scopi didattici e dimostrativi**

_Mostra le potenzialità di Blazor WebAssembly nello sviluppo di applicazioni web moderne_

---

### 🎓 Nota per gli sviluppatori

Questo progetto rappresenta un **esempio pratico e completo** di come implementare una Single Page Application utilizzando Blazor WebAssembly. È particolarmente utile per:

- 🎯 **Apprendere Blazor** attraverso un caso d'uso reale
- 💼 **Portfolio progetti** per sviluppatori .NET
- 🚀 **Base di partenza** per applicazioni simili
- 📚 **Studio delle best practices** in architettura component-based

**⭐ Se ti è piaciuto il progetto, lascia una stella!**

</div>
