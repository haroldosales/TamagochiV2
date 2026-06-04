# Tamagochi

A simple digital pet application built with .NET MAUI targeting .NET 10. The project demonstrates a small interactive UI, state management and basic game mechanics for a virtual pet.

## Features
- Feed, play and rest mechanics
- Pet status indicators (hunger, happiness, energy)
- Simple persistent state storage
- Cross-platform UI via .NET MAUI

## Requirements
- .NET 10 SDK
- Visual Studio 2026 with .NET MAUI workload (or `dotnet` CLI with MAUI support)
- Windows / macOS / Android / iOS SDKs as required for your target platforms

## Getting started

1. Open the solution in Visual Studio 2026:
   - File > Open > Project/Solution and select `Tamagochi.sln`.
2. Or use the CLI:
   - Restore: `dotnet restore`
   - Build: `dotnet build`

## Run (Visual Studio)
- Select the target platform (Windows, Android emulator, iOS simulator) in the toolbar.
- Press F5 to run with the debugger or Ctrl+F5 to run without debugging.

## Run (CLI)
- Windows (desktop):
  - `dotnet build -f net10-windows`
  - Run the produced executable from the output folder
- For other platforms, use the appropriate MAUI publish/run commands or Visual Studio tooling.

## Tests
- If the solution contains test projects:
  - Run all tests from Visual Studio Test Explorer.
  - Or via CLI: `dotnet test`

## Project structure (example)
- src/ — MAUI app project
- src/Models — domain models (Pet, Status)
- src/ViewModels — view model logic
- src/Views — UI pages and controls
- tests/ — unit tests (if present)

## Contributing
- Fork the repository, create a feature branch and submit a pull request.
- Keep changes small and focused; include tests for new logic where appropriate.

## License
Specify your license here (e.g. MIT). Update LICENSE file in the repository.

---
If you want, I can add screenshots, a roadmap, or a Portuguese version of this README.