# OPDBApiWrapper

The [Open Pinball Database (OPDB)](https://opdb.org/) is a searchable archive of pinball machines with a focus on providing a solid API for software developers who wish to incorporate pinball machine data into their apps. It is a free resource, both free as in beer and free as in speech. The service is provided free of charge and can be freely used by anyone for any purpose.

OPDBApiWrapper is a C#, .net standard 2.0 class library that provides a wrapper for the OPDB API. This library is designed to simplify the interaction with the OPDB API by providing strongly typed models and a straightforward interface for making API calls. To use the OPDB API, an API token must be obtained.

## Installation
Add the project to your solution and reference it in your application.

## Usage
```csharp
using OPDBApiWrapper;

var apiToken = "YOUR_OPDB_API_TOKEN";
var client = new OPDBApiClient(apiToken);

var machine = await client.GetMachineByIpdbIdAsync(1234);
```

## API Reference
See the official [OPDB API Documentation](https://opdb.org/api) for details on endpoints and parameters.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.