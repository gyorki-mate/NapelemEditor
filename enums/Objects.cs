using NapelemEditor.Components;

namespace NapelemEditor;

public class Objects
{
    public Objects(double x, double y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public bool isLocked { get; set; } = false;
}