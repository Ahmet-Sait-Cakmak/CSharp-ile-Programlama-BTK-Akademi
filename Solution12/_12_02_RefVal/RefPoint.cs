internal class RefPoint
{
    public int x { get; set; }
    public int y { get; set; }

    public RefPoint(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public override string ToString() => $"RefPoint: {x}, {y}";
}