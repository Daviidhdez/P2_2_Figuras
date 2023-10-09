using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
    protected Color _color;
    private Color color;

    protected Figura(Color color)
    {
        this.color = color;
    }

    public abstract double GetArea();

}