# MatchPlayApiWrapper

A .NET library for interacting with the Match Play API, providing models and a client for accessing tournament, player, game, and statistics data.

## Features
- Strongly-typed models for all major Match Play API entities
- `MatchPlayApiClient` for easy API access
- Async methods for retrieving tournaments, games, players, stats, and more
- Organized code structure with each model in its own file

## Getting Started

### Prerequisites
- .NET Standard 2.0 or higher
- Newtonsoft.Json

### Installation
Add the project to your solution and reference it in your application.

### Usage Example
```csharp
using MatchPlayApiWrapper;

var client = new MatchPlayApiClient("https://api.matchplay.com", "YOUR_BEARER_TOKEN");
var tournaments = await client.GetTournamentsAsync();
```

## Project Structure
- `MatchPlayApiClient.cs` — Main API client
- `Models/` — All data models (Tournament, Game, Player, etc.)
- Each model is in its own file for clarity and maintainability

## Contributing
Pull requests and issues are welcome! Please follow standard C# coding conventions.

## License
MIT

## API Reference
See [Match Play API Documentation](https://api.matchplay.com/docs) for endpoint details.
