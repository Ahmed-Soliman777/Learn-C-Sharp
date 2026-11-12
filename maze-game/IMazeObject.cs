namespace MazeGame
{
    public interface IMazeObject
    {
        char Icon { get; } // the shape of the move object (pixel of wall, etc..)

        bool ISolid { get; } // movement block
    }
}