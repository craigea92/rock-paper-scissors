class RockPaperScissors {

  private int playerScore;
  private int enemyScore;

  public RockPaperScissors() {
    playerScore = 0;
    enemyScore = 0;
    
    Console.WriteLine("Welcome to Rock, Paper, Scissors!");
  }

  public void StartGame() {
    
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