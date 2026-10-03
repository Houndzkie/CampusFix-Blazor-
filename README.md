# CampusFix Blazor UI

A lightweight .NET 10 Blazor Web App recreating the CampusFix maintenance portal UI.

## Run

Install the .NET 10 SDK and Node.js, then build the Tailwind stylesheet and run:

```powershell
npm install
npm run build:css
dotnet run
```

Open the local URL printed by `dotnet run`.

During UI development, run `npm run watch:css` in a separate terminal so Tailwind
rebuilds `wwwroot/tailwind.css` as Razor markup changes.

## Demo behavior

The dashboard, sign-in and registration screens, ticket list/create/detail flow, comments, status updates, notifications, profile, preferences, and searchable Help Center are interactive. Sample tickets and changes are stored in memory and reset when the app restarts. There is no database, authentication provider, Supabase, or custom JavaScript. The shared app shell and Help Center use Tailwind CSS (`Styles/tailwind.input.css` compiled to `wwwroot/tailwind.css`); existing page-specific styles remain in `wwwroot/campusfix.css`.