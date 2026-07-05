
int player1RandomNumber;
int player2RandomNumber;

int player1Score = 0;
int player2Score = 0;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any Key to roll the dice");
    Console.ReadKey();

    player1RandomNumber = random.Next(1, 7);
    Console.WriteLine($"You Rolled a {player1RandomNumber}");

    Console.WriteLine("...");
    Thread.Sleep(1000);

    player2RandomNumber =random.Next(1, 7);
    Console.WriteLine($"Enemy Rolled a {player2RandomNumber}\n");

    if (player1RandomNumber > player2RandomNumber)
    {
        player1Score++;
        Console.WriteLine("player 1 wins this rouend");
    }
    else if (player1Score < player2Score)
    {
        player2Score++;
        Console.WriteLine("Player2 wins this round");
    }
    else
    {
     Console.WriteLine("Draw");   
    }

    Console.WriteLine($"Player1 score: {player1Score}, Player2 score: {player2Score}");
    Console.WriteLine();

}