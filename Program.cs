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
    while(playerScore != 3 && computerScore != 3)
    {
      Console.WriteLine($"| Player Score: {playerScore} | Computer Score: {computerScore} |");
      Console.WriteLine("Please enter 'r' for Rock, 'p' for Paper or 's' for Scissors");
      string playerChoice = Console.ReadLine();

      int enemyChoice = random.Next(0, 3);
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