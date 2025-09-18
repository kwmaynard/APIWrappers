# IFPAApiWrapper

A C# client library for accessing the IFPA Pinball API.

## Overview
This library provides an easy way to interact with the [IFPA Pinball API](https://www.ifpapinball.com/api/documentation/) to retrieve information about players, tournaments, rankings, directors, and statistics.

## Features
- Get details for players, tournaments, directors, and series
- Search for players, directors, and tournaments
- Retrieve rankings and statistics by country, state, region, and series
- All API endpoints are wrapped in async methods

## Installation
Add the project to your solution and reference it in your application.

## Usage
```
csharp
using IFPAApiWrapper;
using System.Net.Http;

var apiKey = "YOUR_IFPA_API_KEY";
var client = new IFPAApiClient(apiKey);

// Get player details
var player = await client.GetPlayerAsync(1234);

// Search for tournaments
var tournaments = await client.SearchTournamentsAsync(name: "Pinburgh");
```

## API Documentation
See the official [IFPA API Documentation](https://www.ifpapinball.com/api/documentation/) for details on endpoints and parameters.

## Models
All responses are mapped to strongly-typed model classes in the `Models` folder.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
MIT License.
