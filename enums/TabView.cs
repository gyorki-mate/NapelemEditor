using Microsoft.AspNetCore.Components;

namespace NapelemEditor;

public class TabView
{
    public string Orientation { get; set; }
    public string Name { get; set; }
    public List<Objects> Obstacles = new();
    public List<Objects> Panels = new();
    public Guid Id { get; set; }
    public bool CanvasLocked { get; set; }
    public string Width { get; set; } = "1200";
    public string Height { get; set; } = "500";
}