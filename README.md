Number Guess Game

Welcome to the Number Guess Game! This is a simple console application where the player has to guess a randomly generated number within a specified range. The application provides feedback whether the guess is too high, too low, or correct.

Features

The game generates a random number within a predefined range.
The player has multiple attempts to guess the correct number.
The game provides feedback on whether the guess is too high or too low.
Once the player guesses correctly, the game will display a success message and the number of attempts taken.
Prerequisites

To run this game, you'll need:

.NET SDK installed on your machine (for example, .NET 6 or higher).
A compatible IDE such as JetBrains Rider or Visual Studio.
Installation

Clone the repository:
git clone https://github.com/your-username/number-guess-game.git
Navigate to the project directory:
cd number-guess-game
Build the project (if needed):
dotnet build
Run the application:
dotnet run
How to Play

When you run the application, it will ask you to guess a number between a specified range (e.g., 1 to 100).
Input your guess and press Enter.
The game will tell you if your guess is too low, too high, or correct.
Keep guessing until you find the correct number.
After a correct guess, the game will tell you how many attempts you made.
Example Gameplay

Welcome to Number Guess Game!
I have picked a number between 1 and 100. Try to guess it!

Your guess: 50
Too high! Try again.

Your guess: 25
Too low! Try again.

Your guess: 37
Correct! You guessed the number in 3 attempts.
Game Customization

You can change the range of numbers or the number of attempts in the Program.cs file by modifying the appropriate variables.

License

This project is licensed under the MIT License - see the LICENSE file for details.
