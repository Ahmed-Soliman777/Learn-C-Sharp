namespace MazeGame
{
    internal class EmptySpace : IMazeObject
    {
         public char Icon { get => ' '; }

        public bool ISolid { get => false; }
    }
}