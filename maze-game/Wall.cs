namespace MazeGame
{
    internal class Wall : IMazeObject
    {
        public char Icon { get => '#'; }

        public bool ISolid { get => true; }

    }
}