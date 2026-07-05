
int playerRandomNumber;
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any Key to roll the dice");
    Console.ReadLine();

    playerRandomNumber = random.Next(1, 7);
}