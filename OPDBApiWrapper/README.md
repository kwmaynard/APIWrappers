# OPDBApiWrapper

OPDBApiWrapper is a C# class library that provides a wrapper for the OPDB API. This library is designed to simplify the interaction with the OPDB API by providing strongly typed models and a straightforward interface for making API calls.

## Features

- Targeted for .NET Standard 2.0
- Utilizes C# language version 7.3
- Includes support for JSON serialization and deserialization using Newtonsoft.Json
- Provides a clean and easy-to-use interface for accessing OPDB API endpoints

## Installation

To use the OPDBApiWrapper in your project, add a reference to the library in your project file:

```xml
<PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
```

## Usage

1. Initialize the `OPDBApiWrapper` class.
2. Use the provided methods to interact with the OPDB API.

### Example

```csharp
var apiWrapper = new OPDBApiWrapper();
var response = await apiWrapper.SomeApiMethodAsync();
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.