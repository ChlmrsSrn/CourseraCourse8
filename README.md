# SafeVault

SafeVault is a secure web application designed to manage sensitive data, including user credentials and financial records. This application implements secure coding practices to protect against common vulnerabilities such as SQL injection and cross-site scripting (XSS).

## Project Structure

The project is organized into the following directories and files:

- **Controllers**: Contains the application's controllers that handle user requests and responses.
  - `HomeController.cs`: Manages the main routes and actions of the application.

- **Models**: Defines the data structures used in the application.
  - `User.cs`: Represents the user entity with properties such as UserID, Username, and Email.

- **Views**: Contains the Razor views for rendering HTML.
  - **Home**: Contains views related to the home page.
    - `Index.cshtml`: The main view for the home page.
  - **Shared**: Contains shared layout files.
    - `_Layout.cshtml`: The layout template for the application.

- **Data**: Contains the database context for Entity Framework.
  - `SafeVaultContext.cs`: Manages the connection to the database and includes DbSet properties for accessing the User model.

- **Tests**: Contains unit tests for the application.
  - `TestInputValidation.cs`: Tests for input validation, including checks for SQL injection and XSS vulnerabilities.

- **Configuration Files**:
  - `appsettings.json`: Configuration settings for the application, including database connection strings.
  - `Program.cs`: The entry point of the application.
  - `Startup.cs`: Configures services and the application's request pipeline.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd SafeVault
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## Usage

Once the application is running, you can access it in your web browser at `http://localhost:5000`. The home page will allow you to interact with the application and manage user data securely.

## Security Practices

SafeVault implements the following security practices:

- Input validation to prevent malicious injections.
- Parameterized queries to eliminate SQL injection vulnerabilities.
- Unit tests to ensure the application resists XSS and SQL injection attacks.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.