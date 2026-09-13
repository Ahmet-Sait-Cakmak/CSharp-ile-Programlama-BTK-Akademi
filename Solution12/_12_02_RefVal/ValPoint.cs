internal struct ValPoint
{
    public int x;

    public int y;

    public ValPoint(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public override string ToString() => $"ValPoint {x}, {y}";
}
