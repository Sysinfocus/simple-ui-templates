# SimpleUITemplates.UI.Tailwind

## Development Setup

1. Install standalone Tailwind CSS CLI executable:

   Mac/Linux:mkdir .\tools -Force; cd .\tools; Invoke-WebRequest -Uri https://github.com/tailwindlabs/tailwindcss/releases/download/v3.4.15/tailwindcss-windows-x64.exe -OutFile tailwindcss.exe -UseBasicParsing ; cd ..

   ```bash
   mkdir ./tools && cd ./tools && curl -sLO https://github.com/tailwindlabs/tailwindcss/releases/download/v3.4.15/tailwindcss-macos-arm64  && chmod +x tailwindcss-macos-arm64 && mv tailwindcss-macos-arm64 tailwindcss
   ```

   Windows:

   ```pwsh
   mkdir ./tools -Force; `
   cd ./tools; `
   Invoke-WebRequest -Uri "https://github.com/tailwindlabs/tailwindcss/releases/download/v3.4.15/tailwindcss-windows-x64.exe" `
      -OutFile "tailwindcss.exe" `
      -UseBasicParsing ; `
   cd ..

   ```

1. Build the solution

   ```bash
   dotnet build
   ```

1. Run the Blazor WASM Static Web App

   ```bash
   dotnet watch
   ```

## Development Workflow

### Local Development

There will be two teminal session running in the background:

- One for the Blazor WASM Static Web App
- One for the Tailwind CSS CLI

**Blazor WASM Static Web App:**

```bash
dotnet watch
```

**Tailwind CSS CLI:**

```bash
.\tools\tailwindcss.exe -i ./wwwroot/css/app.css -o ./wwwroot/css/app.min.css --watch
```
