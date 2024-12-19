# Number Guessing Game

Welcome to the Number Guessing Game! This is a simple console application written in C# that allows players to guess a random number between 1 and 100. The game provides three difficulty levels (Easy, Medium, and Hard), each with different numbers of chances to guess the correct number.

## Features

- **Difficulty Levels**: 
  - **Easy**: 10 chances to guess the number.
  - **Medium**: 5 chances to guess the number.
  - **Hard**: 3 chances to guess the number.
  
- **User Input Validation**: If the user inputs an invalid number, the game will inform them and prompt for another input.
  
- **Replay Option**: After completing a round, users can choose to play again or exit the game.

## Roadmap

If you want to explore the detailed roadmap and plan for the future enhancements of this project, check out the roadmap for the Number Guessing Game here: [Number Guessing Game Roadmap](https://roadmap.sh/projects/number-guessing-game).

## Requirements

- .NET Framework 4.5 or higher
- C# compiler or Visual Studio to run the code

## How to Run

1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/Number-Guessing-Game.git
    ```

2. Navigate to the project directory:
    ```bash
    cd Number-Guessing-Game
    ```

3. Open the solution in Visual Studio or use the C# compiler to run the `Program.cs` file.

4. Follow the on-screen instructions to play the game.

## Game Instructions

1. The game will prompt you to select a difficulty level:
    - **1**: Easy (10 chances)
    - **2**: Medium (5 chances)
    - **3**: Hard (3 chances)

2. After selecting a difficulty, the game will prompt you to enter a guess. If the guess is too high or too low, the game will give feedback on how to adjust your guess.

3. Once you guess the number or run out of chances, the game will tell you whether you won or lost, and ask if you'd like to play again.

4. You can choose to either play again or exit the game after each round.

## Code Explanation

- **`Game` class**: Contains the logic of the game, including handling the random number generation, user input, and the difficulty level selection.
  
- **Difficulty Levels**: The number of chances changes based on the difficulty level chosen by the player.
  
- **Replay Functionality**: After completing a round, the player is asked if they would like to play again.

## Example

