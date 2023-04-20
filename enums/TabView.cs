namespace NapelemEditor;

public class TabView
{
    public string Orientation { get; set; }
    public string Name { get; set; }
    public List<Objects> Obstacles = new();
    public List<Objects> Panels = new();
    public Guid Id { get; set; }

    public bool CanvasLocked { get; set; }

    //Sizes are stored in ms
    public int Width { get; set; } = 10;
    public int Height { get; set; } = 10;
}