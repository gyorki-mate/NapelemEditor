﻿using NapelemEditor.Components;

namespace NapelemEditor;

public class Objects
{
    public Objects(double x, double y, int width, int height, int price=0, int output=0)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Price = price;
        Output = output;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool isLocked { get; set; } = false;
    public int Price { get; set; }
    public int Output { get; set; }
}