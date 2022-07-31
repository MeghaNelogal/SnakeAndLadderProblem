namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Welome To Snake And Ladder Problem\n***");
            SnakeAndLadderGame snakeAndLadderGame = new SnakeAndLadderGame();
            //snakeAndLadderGame.CheckDieRoll();
            snakeAndLadderGame.Game();
        }
    }
}