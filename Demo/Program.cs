namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 – What is .NET
            // .NET is a software development platform by Microsoft.
            // It provides:
            //  - Runtime environment (CLR – Common Language Runtime)
            //  - Class Library (BCL – Base Class Library)
            //  - Multi-language support (C#, F#, VB.NET)
            //
            // ✅ CLR handles memory, exceptions, JIT compilation, and garbage collection.
            // ✅ You can build: Web, Desktop, Mobile, Games, IoT, AI apps.
            //
            // Tools: Visual Studio / VS Code
            #endregion
            #region Part 02 – MVC Pattern
            // MVC stands for Model – View – Controller
            // - Model: Data layer (Entities, ViewModels, Validation).
            // - View: UI layer (Razor .cshtml).
            // - Controller: Handles HTTP requests, links Model + View.
            //
            // 🔹 Advantages:
            //  - Separation of concerns
            //  - Reusable and testable
            //  - Better organization for large systems 
            #endregion
            #region Part 03 – HTTP Request / Response Model
            // HTTP (HyperText Transfer Protocol) defines how client and server communicate.
            //
            // 🔸 Request: Sent by client (browser) -> Server
            //     Includes Headers, URL, Method, Body
            //
            // 🔸 Response: Sent by server -> Client
            //     Includes Status Code (200 OK, 404 NotFound, 500 Error)
            //
            // HTTP Verbs: GET, POST, PUT, DELETE, PATCH
            // SSL/TLS provides Encryption + Authentication + Integrity.
            #endregion
            #region Part 04 – URL & Resources
            // URL (Uniform Resource Locator): identifies resources on the web.
            //
            // Example: https://localhost:5001/Home/Index
            //    → Controller = Home, Action = Index
            //
            // Base URL = Root address of the site.
            //
            // 🌍 Servers can be:
            //    - Physical (dedicated hardware)
            //    - Virtual (shared hardware via hypervisor)
            //
            // Static Resources: CSS, JS, images stored under wwwroot/
            #endregion
            #region Part 05 – Project Deployment
            // ASP.NET apps are hosted on web servers (IIS, Kestrel, or Cloud).
            //
            // 🔹 IIS (Internet Information Services):
            //   Windows web server for hosting .NET apps.
            //
            // 🔹 Hosting Models:
            //   1. In-Process Hosting  → App runs inside IIS (best for Windows).
            //   2. Out-of-Process Hosting → IIS acts as reverse proxy to Kestrel.
            //
            // Command: dotnet publish -c Release -o ./publish
            //
            // Use proper configuration via appsettings.json before deployment.
            #endregion
            #region Part 06 – Project Structure
            // Default ASP.NET MVC structure:
            //   - Controllers → Handle HTTP requests
            //   - Models → Data + Validation logic
            //   - Views → UI (.cshtml Razor files)
            //   - wwwroot → Static resources
            //
            // 3-Layer Architecture:
            //   - Presentation Layer → MVC (UI, Controllers)
            //   - Business Logic Layer → Core logic, rules
            //   - Data Access Layer → Database (EF Core, Repositories)
            //
            // Repository Pattern → separates data access from business logic.
            // Dependency Injection → injects required services automatically.
            #endregion  

        }
    }
}
