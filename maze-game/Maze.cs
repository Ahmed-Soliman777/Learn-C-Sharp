namespace MazeGame
{
    public class Maze
    {
        private int _Width;

        private int _Height;

        private Player _Player;

        private IMazeObject[,] _MazeObjectArray;

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;

            _MazeObjectArray = new IMazeObject[width, height];

            _Player = new Player()
            {
                X = 1,
                Y = 1,
            };

        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    if (_Player.X == _Width - 1 && _Player.Y == _Height - 3)
                    {
                        Console.WriteLine("You won the game!");
                        Environment.Exit(0);
                    }
                    if (x == _Width - 1 && y == _Height - 3)
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();

                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
                    {
                        _MazeObjectArray[x, y] = new Wall();

                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        _MazeObjectArray[x, y] = new Wall();

                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();

                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo UserInput = Console.ReadKey();

            ConsoleKey Key = UserInput.Key;

            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
            }
        }

        private void UpdatePlayer(int dx, int dy)
        {
            int NewX = _Player.X + dx;
            int NewY = _Player.Y + dy;

            if (
                NewX < _Width &&
                NewX >= 0 &&
                NewY < _Height &&
                NewY >= 0 &&
                _MazeObjectArray[NewX, NewY].ISolid == false
                )
            {
                _Player.X = NewX;
                _Player.Y = NewY;
                DrawMaze();
            }
        }
    }
}