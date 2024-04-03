class RockPaperScissors {

  private int playerScore;
  private int computerScore;
  Random random = new();

  public RockPaperScissors() {
    playerScore = 0;
    computerScore = 0;
    
    Console.WriteLine("********** Welcome to Rock, Paper, Scissors! **********");
  }

  public void StartGame() {
    while(playerScore < 3 && computerScore < 3)
    {
      Console.WriteLine(); // Print a blank line
      Console.WriteLine($"| Player Score: {playerScore} | Computer Score: {computerScore} |");
      Console.WriteLine("Please enter 'r' for Rock, 'p' for Paper or 's' for Scissors");
      string playerChoice = Console.ReadLine();

      int computerChoice = random.Next(0, 3);

      if (computerChoice == 0) // Computer chooses Rock
        {
          Console.WriteLine("Computer chose Rock.");

          switch (playerChoice)
          {
            case "r":
              Console.WriteLine("Tie!");
              break;
            case "p":
              Console.WriteLine("Player Wins!");
              playerScore++;
              break;
            case "s":
              Console.WriteLine("Computer Wins!");
              computerScore++;
              break;
            default:
              Console.WriteLine("Invalid choice!");
              break;
          }
        }
        else if (computerChoice == 1) // Computer chooses Paper
        {
          Console.WriteLine("Computer chose Paper.");

          switch (playerChoice)
          {
            case "r":
              Console.WriteLine("Computer Wins!");
              computerScore++;
              break;
            case "p":
              Console.WriteLine("Tie!");
              break;
            case "s":
              Console.WriteLine("Player Wins!");
              playerScore++;
              break;
            default:
              Console.WriteLine("Invalid choice!");
              break;
          }
        }
        else if (computerChoice == 2) // Computer chooses Scissors
        {
          Console.WriteLine("Computer chose Scissors.");

          switch (playerChoice)
          {
            case "r":
              Console.WriteLine("Player Wins!");
              playerScore++;
              break;
            case "p":
              Console.WriteLine("Computer Wins!");
              computerScore++;
              break;
            case "s":
              Console.WriteLine("Tie!");
              break;
            default:
              Console.WriteLine("Invalid choice!");
              break;
          }
        }
      }
    
    if (playerScore == 3)
    {
      Console.WriteLine();
      Console.WriteLine($"| Player Score: {playerScore} | Computer Score: {computerScore} |");
      Console.WriteLine("Player Wins! Well Done!");
    } 
    else
    {
      Console.WriteLine();
      Console.WriteLine($"| Player Score: {playerScore} | Computer Score: {computerScore} |");
      Console.WriteLine("Computer Wins! Better luck next time...");
    }
    }
}

class Program
{
    static void Main(string[] args)
    {
        RockPaperScissors game = new();
        game.StartGame();
    }
}