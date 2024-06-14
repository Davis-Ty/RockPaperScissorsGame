# RockPaperScissorsGame
This project implements the classic Rock, Paper, Scissors game using ASP.NET Core's minimal API approach. It provides a web interface where users can play against the computer. The project demonstrates clean coding practices and uses modern web development techniques.

# Project Structure and Good Programming Methods
# Game Logic (GameDo Class)
The game logic is encapsulated in the GameDo class, adhering to good object-oriented principles:

- Encapsulation: Properties (inputPlayer, inputCPU, randomInt) are encapsulated to maintain data integrity and provide controlled access.
- Single Responsibility Principle: Methods like Play, CpuMove, and Winner handle specific tasks related to game play, ensuring each method has a clear responsibility.
- SOLID Principles: The class design supports principles like Single Responsibility Principle (SRP) and Separation of Concerns, promoting maintainability and testability.
# Web Application (Minimal API Setup)
The web application is set up using ASP.NET Core's minimal API, focusing on simplicity and efficiency:

- Routing: Routes are defined directly in Program.cs using app.MapGet and app.MapPost, which makes the application easy to understand and maintain for small-scale applications.
- Separation of Concerns: The game logic Game.cs (GameDo class) is separate from the web presentation (Program.cs), promoting modularity and reusability of the game logic in other contexts.
- Error Handling: Development and production error handling are differentiated using if (app.Environment.IsDevelopment()) block, providing a smooth user experience and effective debugging.
# How to Run
- Clone the repository:

  
# Copy code
- git clone https://github.com/yourusername/RockPaperScissorsWebGame.git
- cd RockPaperScissorsWebGame
Run the application:

  
# Copy code
- dotnet run
Open your browser and navigate to https://localhost:5001. You will see the game interface where you can play Rock, Paper, Scissors.

# Technologies Used
- ASP.NET Core
- C#
# Purpose
This project serves as a practical example of:

- Implementing game logic in C# with good object-oriented design principles.
- Setting up a minimal web API using ASP.NET Core for simple applications.
- Demonstrating clean coding practices and modern web development techniques.
