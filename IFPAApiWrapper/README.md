# IFPAApiWrapper

The objective of the [International Flipper Pinball Association (IFPA)](https://www.ifpapinball.com/) is to serve as the governing body for pinball as a competitive sport, through the sanctioning and organizing of events at the Local, State, National and International levels.

IFPAApiWrapper is a C#, .net standard 2.0 class library that provides a wrapper for the IFPA API. This library is designed to simplify the interaction with the IPFA API by providing strongly typed models and a straightforward interface for making API calls. To use the IFPA API, an API key must be obtained.

## Installation
Add the project to your solution and reference it in your application.

## Usage
```csharp
using IFPAApiWrapper;

var apiKey = "YOUR_IFPA_API_KEY";
var client = new IFPAApiClient(apiKey);

var player = await client.GetPlayerAsync(1234);

var tournaments = await client.SearchTournamentsAsync(name: "Pinburgh");
```

## API Reference
See the official [IFPA API Documentation](https://www.ifpapinball.com/api/documentation/) for details on endpoints and parameters.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.