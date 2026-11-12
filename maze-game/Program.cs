namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to maze game!");
            Console.WriteLine("Use keyboard arrows to move the player");
            Console.WriteLine("*************************");

            Maze maze = new Maze(50, 20);

            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
        }
    }
}