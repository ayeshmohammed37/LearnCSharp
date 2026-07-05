
int player1RandomNumber;
int player2RandomNumber;
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
    Console.WriteLine($"Enemy Rolled a {player2RandomNumber}");

}