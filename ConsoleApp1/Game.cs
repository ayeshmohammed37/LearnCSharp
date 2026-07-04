public class Game
{
    public Human[] human;

    public Game()
    {
        human = new Human[4];
    }

    public void Run(IMovable[] obj)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].Move();
        }
        
    }
}