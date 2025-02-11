
# MotoCenter API

MotoCenter API is a .NET 9 web API for managing motorcycle-related data. This project provides endpoints for various operations such as retrieving weather forecasts and managing motorcycle information.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Clone the repository:

    git clone https://github.com/yourusername/MotoCenter.git

2. Navigate to the project directory:

    cd MotoCenter

3. Restore the dependencies:

    dotnet restore

4. Build the project:

    dotnet build

## Usage

1. Run the application:

    dotnet run --project MotoCenter.API

2. The API will be available at `https://localhost:5001`.

## Endpoints

### Motorcycle Management

- **GET** `/motorcycles`
    - Retrieves a list of motorcycles.
- **POST** `/motorcycles`
    - Adds a new motorcycle.
- **PUT** `/motorcycles/{id}`
    - Updates an existing motorcycle.
- **DELETE** `/motorcycles/{id}`
    - Deletes a motorcycle.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
