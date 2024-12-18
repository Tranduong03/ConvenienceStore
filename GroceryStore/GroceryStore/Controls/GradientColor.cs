using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class GradientColor
{
    public Color Color1 { get; set; }
    public Color Color2 { get; set; }
    public float Angle { get; set; }

    public GradientColor(Color color1, Color color2, float angle)
    {
        Color1 = color1;
        Color2 = color2;
        Angle = angle;
    }

    public LinearGradientBrush CreateGradientBrush(Rectangle bounds)
    {
        return new LinearGradientBrush(bounds, Color1, Color2, Angle);
    }

    // Optionally override ToString for debugging or display purposes
    public override string ToString()
    {
        return $"GradientColor [Color1={Color1}, Color2={Color2}, Angle={Angle}]";
    }
}
