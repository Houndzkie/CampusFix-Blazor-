# CampusFix Blazor UI

A lightweight .NET 10 Blazor Web App recreating the CampusFix maintenance portal UI.

## Run

Install the .NET 10 SDK, then run:

```powershell
dotnet run
```

Open the local URL printed by `dotnet run`.

## Demo behavior

The dashboard, sign-in and registration screens, ticket list/create/detail flow, comments, status updates, notifications, profile, and preferences are interactive. Sample tickets and changes are stored in memory and reset when the app restarts. There is no database, authentication provider, Supabase, or custom JavaScript. Styling is plain CSS in `wwwroot/campusfix.css`.