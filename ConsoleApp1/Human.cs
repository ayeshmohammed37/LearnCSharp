public class Human() : Creature, IMovable
{
    public override void Move()
    {
        Console.WriteLine("Human is Moving");
    }
}