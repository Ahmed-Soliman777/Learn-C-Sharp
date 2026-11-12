namespace MazeGame
{
    internal class Player : IMazeObject
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Icon { get => '@'; }

        public bool ISolid { get => true; }
    }
}