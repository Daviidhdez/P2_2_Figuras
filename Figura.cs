using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{

    protected Color color;
    internal double _radio;
    internal int _longitudLado;

    protected Figura(Color color)
    {
        this.color = color;
    }

    public Color Color { get; set; }

    public abstract double GetArea();
    public override string ToString()
    {
        return $" \n{color}";
    }
}