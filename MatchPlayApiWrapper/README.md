# MatchPlayApiWrapper

[Match Play](https://app.matchplay.events/) has served as the one-stop solution for pinball tournaments. Over a dozen different tournament formats are available from simple brackets to pinball-specific formats like four-player elimination brackets and Flip Frenzies. Players can follow along from their mobile devices and view historical data for past events.

MatchPlayApiWrapper is a C#, .net standard 2.0 class library that provides a wrapper for the MatchPlay API. This library is designed to simplify the interaction with the MatchPlay API by providing strongly typed models and a straightforward interface for making API calls. To use the MatchPlay API, a bearer token must be obtained.

## Installation
Add the project to your solution and reference it in your application.

## Usage
```csharp
using MatchPlayApiWrapper;

var bearerToken = "YOUR_MATCHPLAY_BEARER_TOKEN";
var client = new MatchPlayApiClient(bearerToken);

var tournaments = await client.GetTournamentsAsync();

var tournament = await client.GetTournamentByIdAsync(1234);
```

## API Reference
See [Match Play API Documentation](https://api.matchplay.com/docs) for details on endpoints and parameters.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.