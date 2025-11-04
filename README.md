# Library Portal – Blazor Webassembly

A web-based library portal built using **Blazor** for managing books, categories, authors.

---

## Features

- CRUD operations on books, categories, authors  
- Search, filtering, pagination  
- Responsive UI using Blazor components  
- API integration layer (to backend services)  
- Configuration via settings (e.g. API endpoints)  

---

## Architecture & Tech Stack

- **Frontend / UI**: Blazor Webassembly
- **Backend / API Layer**: ASP.NET Core Web API  
- **Data / Storage**: MS SQL Server
- **Languages & Tools**:  
  - C# (Blazor, .NET 9.0)  
  - HTML / CSS  
  - JSON for configuration  

---

## Getting Started

### Prerequisites

Before running, ensure you have:

- [.NET SDK 9.0 ]  
- An IDE or code editor (e.g. Visual Studio, VS Code)
- Backend API service running (or mock API endpoints for testing)
- [You can use this REST API](https://github.com/rashedulalam46/library-api-sqlserver) 

### Setup & Run

1. Clone this repository:

   ```bash
   git clone https://github.com/rashedulalam46/library-portal-blazor-webassembly-app.git
   cd library-portal-blazor-webassembly-app
   ```
   
2. Open the solution in your IDE (e.g. LibraryPortalBlazorWebAssemblyApp.sln).

 - Configure settings: In appsettings.json / appsettings.Development.json, update the API endpoint or connection string.
 - If you have an ApiSettings.cs, adjust base URLs etc.

3. Build & run:
```
dotnet build
dotnet run
```

Or run from your IDE with debugging.

4. Navigate to https://localhost:5001 (or the configured port) in your browser.

# Project Structure

```
/
│
├── Components/        # Reusable Blazor components  
├── Models/            # Data models / DTOs  
├── Pages/             # Blazor pages / routing  
├── Services/           # Services (API clients, business logic)  
├── wwwroot/            # Static assets (css, js, images)  
├── ApiSettings.cs      # Configuration helper  
├── Program.cs          # App startup  
├── Routes.razor         # Routing definitions  
├── LibraryPortalBlazorWebAssemblyApp.csproj  
├── LibraryPortalBlazorWebAssemblyApp.sln  
├── appsettings.json  
└── appsettings.Development.json  

```
# Configuration
```
| File                           | Purpose                                    |
| ------------------------------ | ------------------------------------------ |
| `appsettings.json`             | Production settings (e.g. API URL, keys)   |
| `appsettings.Development.json` | Local / development overrides              |
| `ApiSettings.cs`               | Strongly-typed class for API configuration |
```






